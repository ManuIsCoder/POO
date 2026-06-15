using Clinicamedica;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ClinicaMedica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new ClinicaContext();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1 - Registrar nuevo turno");
                Console.WriteLine("2 - Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarTurno(context);
                        break;
                    case "2":
                        salir = true;
                        break;
                    default:
                        break;
                }
            }
        }

        static void RegistrarTurno(ClinicaContext context)
        {
            Console.WriteLine("DNI:");
            string inputDni = Console.ReadLine();
            if (!int.TryParse(inputDni, out int dni))
            {
                return;
            }

            var paciente = context.Pacientes.FirstOrDefault(p => p.Dni == dni);
            if (paciente != null)
            {
                Console.WriteLine($"{paciente.Nombre} {paciente.Apellido}");
                var turnos = context.Turnos
                    .Include(t => t.Especialidad)
                    .Include(t => t.Medico)
                    .Include(t => t.Estado)
                    .Where(t => t.Dni == dni)
                    .ToList();

                foreach (var t in turnos)
                {
                    Console.WriteLine($"{t.Fecha} {t.Hora} - {t.Especialidad.Nombre} con {t.Medico.Nombre} {t.Medico.Apellido} ({t.Estado.Descripcion})");
                }

                Console.WriteLine("Desea cancelar algun turno? (s/n)");
                string resp = Console.ReadLine();
                if (resp != null && resp.ToLower() == "s")
                {
                    Console.WriteLine("Ingrese Fecha (DD/MM/YYYY):");
                    string f = Console.ReadLine();
                    Console.WriteLine("Ingrese Hora (HH:MM):");
                    string h = Console.ReadLine();
                    var turnoCancelar = turnos.FirstOrDefault(t => t.Fecha == f && t.Hora == h);
                    if (turnoCancelar != null)
                    {
                        var estadoCancelado = context.Estados.FirstOrDefault(e => e.Descripcion.ToLower() == "cancelado");
                        if (estadoCancelado != null)
                        {
                            turnoCancelar.IdEstado = estadoCancelado.IdEstado;
                            context.SaveChanges();
                        }
                    }
                    return;
                }
            }
            else
            {
                paciente = new Paciente { Dni = dni };
                Console.WriteLine("Nombre:");
                paciente.Nombre = Console.ReadLine();
                Console.WriteLine("Apellido:");
                paciente.Apellido = Console.ReadLine();
                Console.WriteLine("Telefono:");
                paciente.Telefono = Console.ReadLine();
                Console.WriteLine("Email:");
                paciente.Email = Console.ReadLine();
                Console.WriteLine("Fecha de Nacimiento:");
                paciente.FechaNacimiento = Console.ReadLine();
                context.Pacientes.Add(paciente);
                context.SaveChanges();
            }

            var especialidades = context.Especialidades.ToList();
            foreach (var e in especialidades)
            {
                Console.WriteLine($"{e.IdEspecialidad} - {e.Nombre}");
            }

            Console.WriteLine("ID Especialidad:");
            string inputEsp = Console.ReadLine();
            if (!int.TryParse(inputEsp, out int idEspecialidad))
            {
                return;
            }
            var especialidad = especialidades.FirstOrDefault(e => e.IdEspecialidad == idEspecialidad);

            var disponibilidades = context.Disponibilidades
                .Include(d => d.Medico)
                .Where(d => d.IdEspecialidad == idEspecialidad)
                .ToList();

            var medicos = disponibilidades.Select(d => d.Medico).GroupBy(m => m.Matricula).Select(g => g.First()).ToList();

            foreach (var m in medicos)
            {
                Console.WriteLine($"{m.Matricula} - {m.Nombre} {m.Apellido}");
            }

            Console.WriteLine("Matricula Medico:");
            string inputMat = Console.ReadLine();
            if (!int.TryParse(inputMat, out int matricula))
            {
                return;
            }
            var medico = medicos.FirstOrDefault(m => m.Matricula == matricula);

            var dispMedico = disponibilidades.Where(d => d.Matricula == matricula).ToList();
            foreach (var d in dispMedico)
            {
                Console.WriteLine($"Dia: {d.DiaSemana} de {d.HoraInicio} a {d.HoraFin}");
            }

            Console.WriteLine("Fecha:");
            string fecha = Console.ReadLine();
            Console.WriteLine("Hora:");
            string hora = Console.ReadLine();

            if (especialidad != null && medico != null)
            {
                Console.WriteLine($"{especialidad.Nombre} con {medico.Nombre} {medico.Apellido} el {fecha} a las {hora}. Confirmar (s/n):");
                string conf = Console.ReadLine();
                if (conf != null && conf.ToLower() == "s")
                {
                    var estadoReservado = context.Estados.FirstOrDefault(e => e.Descripcion.ToLower() == "reservado");
                    int idEst = estadoReservado != null ? estadoReservado.IdEstado : 1;

                    var existingTurno = context.Turnos.FirstOrDefault(t => t.Dni == dni && t.Matricula == matricula && t.IdEspecialidad == idEspecialidad);
                    if (existingTurno != null)
                    {
                        existingTurno.Fecha = fecha;
                        existingTurno.Hora = hora;
                        existingTurno.IdEstado = idEst;
                    }
                    else
                    {
                        var turno = new Turno
                        {
                            Dni = dni,
                            Matricula = matricula,
                            IdEspecialidad = idEspecialidad,
                            Fecha = fecha,
                            Hora = hora,
                            IdEstado = idEst
                        };
                        context.Turnos.Add(turno);
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
