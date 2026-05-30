using System;

public class Carrera
{
    public void competir(IVehiculo v1, IVehiculo v2, int segundos)
    {
        Console.WriteLine("Comienza la carrera por" + segundos + "s");
        
        v1.reiniciarPosicion();
        v2.reiniciarPosicion();

        v1.mover(segundos);
        v2.mover(segundos);

        Console.WriteLine("Posición vehículo 1: " + v1.posicion() + "m");
        Console.WriteLine("Posición vehículo 2: " + v2.posicion() + "m");

        if (v1.posicion() > v2.posicion())
        {
            Console.WriteLine("El vehículo 1 llegó más lejos");
        }
        else if (v2.posicion() > v1.posicion())
        {
            Console.WriteLine("El vehículo 2 llegó más lejos");
        }
        else
        {
            Console.WriteLine("Empate");
        }
    }
}