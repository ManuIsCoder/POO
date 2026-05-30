using System;
using System.Collections.Generic;

public class Mazo
{
    private List<Carta> cartas;
    private Random random;

    public Mazo(){
        cartas = new List<Carta>();
        random = new Random();
        string[] palos = { "Espadas", "Bastos", "Oros", "Copas" };
        string[] numerosYFiguras = { "1", "2", "3", "4", "5", "6", "7", "10 (Sota)", "11 (Caballo)", "12 (Rey)" };

        foreach (string palo in palos){
            foreach (string valor in numerosYFiguras)
                cartas.Add(new Carta(palo, valor));
        }
    }

    public void barajar(){
        int n = cartas.Count;
        while (n > 1){
            n--;
            int k = random.Next(n + 1);
            Carta value = cartas[k];
            cartas[k] = cartas[n];
            cartas[n] = value;
        }
        Console.WriteLine("El mazo ha sido barajado.");
    }

    public Carta? robarCarta(){
        if (cartas.Count == 0){
            Console.WriteLine("Error: El mazo está vacío.");
            return null;
        }
        Carta cartaRobada = cartas[0];
        cartas.RemoveAt(0);
        return cartaRobada;
    }

    public int cuantasCartasQuedan(){
        return cartas.Count;
    }
}