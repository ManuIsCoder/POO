using System;
using Jugadores;

namespace Jugadores
{
    public class Program
    {
        public static void Main()
        {
            IJugadores jugadorAlto = new JugadorRangoAlto();
            jugadorAlto.tiempo = 40;
            jugadorAlto.Correr(40);
            Console.WriteLine("Jugador profesional --TIEMPO: "+jugadorAlto.tiempo);
        }
    }
}