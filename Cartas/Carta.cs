using System;

public class Carta
{
    public string Palo { get; }
    public string NumeroOFigura { get; }

    public Carta(string palo, string Figura)
    {
        Palo = palo;
        NumeroOFigura = Figura;
    }

    public override string ToString()
    {
        return $"{NumeroOFigura} de {Palo}";
    }
}