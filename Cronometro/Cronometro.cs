using System;

public class Cronometro
{
    private int segundos;
    private int minutos;

    public void Reiniciar()
    {
        segundos = 0;
        minutos = 0;
    }

    public void IncrementarTiempo()
    {
        if (segundos >= 59)
        {
            minutos++;
            segundos = 0;
        }
        else
        {
            segundos++;
        }
    }

    public void IncrementarTiempo55()
    {
        segundos += 55;

        if (segundos >= 60)
        {
            minutos += segundos / 60;
            segundos = segundos % 60;
        }
    }

    public void MostrarTiempo()
    {
        Console.WriteLine("Seg. " + segundos + "  Min. " + minutos);
    }
}