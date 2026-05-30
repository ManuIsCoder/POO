using System;

class Program
{
    static void Main(string[] args)
    {
        Mazo mazo = new Mazo();
        
        Console.WriteLine($"Cartas en el mazo: {mazo.cuantasCartasQuedan()}");
        mazo.barajar();
        
        Mano jugador1 = new Mano();
        Mano jugador2 = new Mano();

        Console.WriteLine("\nRepartiendo 3 cartas a cada jugador...");
        for (int i = 0; i < 3; i++)
        {
            jugador1.recibirCarta(mazo.robarCarta());
            jugador2.recibirCarta(mazo.robarCarta());
        }

        Console.WriteLine($"\nCartas restantes en el mazo: {mazo.cuantasCartasQuedan()}");
        
        Console.WriteLine("\nMano del Jugador 1:");
        jugador1.mostrarMano();
        Console.WriteLine($"Cantidad de cartas Jugador 1: {jugador1.cantidadDeCartas()}");

        Console.WriteLine("\nMano del Jugador 2:");
        jugador2.mostrarMano();
        Console.WriteLine($"Cantidad de cartas Jugador 2: {jugador2.cantidadDeCartas()}");
        
        Console.WriteLine("\nRobando todas las cartas restantes...");
        while(mazo.cuantasCartasQuedan() > 0)
        {
            mazo.robarCarta();
        }
        
        Console.WriteLine("\nIntentando robar una carta con el mazo vacío:");
        mazo.robarCarta();
    }
}
