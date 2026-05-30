using System;

class Program
{
    static void Main(string[] args)
    {
        Bicicleta bici = new Bicicleta();
        Camion camion = new Camion();
        Auto autoNormal = new Auto();
        Auto autoRapido = new Auto(60);

        Console.WriteLine("Moviendo vehículos por 5 segundos");
        bici.mover(5);
        camion.mover(5);
        autoNormal.mover(5);
        autoRapido.mover(5);

        Console.WriteLine("Posición de bicicleta: " + bici.posicion() + "m");
        Console.WriteLine("Posición de camión: " + camion.posicion() + "m");
        Console.WriteLine("Posición de auto normal: " + autoNormal.posicion() + "m");
        Console.WriteLine("Posición de auto rápido: " + autoRapido.posicion() + "m");

        Console.WriteLine("\nReiniciando posición de la bicicleta");
        bici.reiniciarPosicion();
        Console.WriteLine("Posición de bicicleta después de reiniciar: " + bici.posicion() + "m");

        Console.WriteLine("\n--- Probando Carrera ---");
        Carrera carrera = new Carrera();
        
        Console.WriteLine("Carrera entre Bicicleta y Auto Normal:");
        carrera.competir(bici, autoNormal, 10);

        Console.WriteLine("\nCarrera entre Camión y Auto Normal:");
        carrera.competir(camion, autoNormal, 15);
    }
}
