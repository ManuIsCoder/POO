using System;

class Program
{
    static void Main(string[] args)
    {
        Cronometro cronometro = new Cronometro();

        cronometro.MostrarTiempo();
        cronometro.IncrementarTiempo();
        cronometro.MostrarTiempo();
        cronometro.IncrementarTiempo55();
        cronometro.IncrementarTiempo();
        cronometro.IncrementarTiempo();
        cronometro.IncrementarTiempo();
        cronometro.MostrarTiempo();
        cronometro.IncrementarTiempo();
        cronometro.MostrarTiempo();
        cronometro.Reiniciar();
        cronometro.MostrarTiempo();
    }
}