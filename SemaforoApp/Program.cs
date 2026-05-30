using System;

class Program
{
    static void Main(string[] args)
    {
        semaforo sem = new semaforo("rojo");

        sem.pasoDelTiempo(1);
        sem.estadoNormalSemaforo();

        sem.pasoDelTiempo(10);
        sem.mostrarColor();

        sem.pasoDelTiempo(30);
        Console.WriteLine("Activando modo intermitente...");
        sem.ponerEnIntermitente();

        sem.pasoDelTiempo(1);
        sem.pasoDelTiempo(1);
        sem.pasoDelTiempo(1);

        sem.intermitente();
        sem.mostrarColor();
    }
}
