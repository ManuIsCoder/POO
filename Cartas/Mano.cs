using System;
using System.Collections.Generic;

public class Mano{
    private List<Carta> cartas;

    public Mano(){
        cartas = new List<Carta>();
    }

    public void recibirCarta(Carta? carta){
        if (carta != null){
            cartas.Add(carta);
        }
    }

    public void mostrarMano(){
        if (cartas.Count == 0){
            Console.WriteLine("La mano está vacía.");
            return;
        }
        
        foreach (Carta carta in cartas){
            Console.WriteLine("- " + carta.ToString());
        }
    }

    public int cantidadDeCartas(){
        return cartas.Count;
    }
}
