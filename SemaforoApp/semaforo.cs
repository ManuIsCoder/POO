using System;

public class semaforo
{
    private string color;
    private int tiempo;
    private bool intermitenteEstado;

    public semaforo(string color_actual)
    {
        color = color_actual;
        tiempo = 0;
        intermitenteEstado = false;
    }

    public void pasoDelTiempo(int tiempoSuma)
    {
        tiempo = tiempo + tiempoSuma;
    }

    public void mostrarColor()
    {
        Console.WriteLine("El color es:" + color);
    }

    public void ponerEnIntermitente()
    {
        if (!intermitenteEstado)
        {
            intermitenteEstado = true;
            color = "rojo";
            tiempo = 0;
        }
    }

    public void sacarDeIntermitente()
    {
        if (intermitenteEstado)
        {
            intermitenteEstado = false;
            color = "rojo";
            tiempo = 0;
        }
    }

    public void intermitente()
    {
        if (intermitenteEstado)
        {
            if (tiempo % 2 == 0)
            {
                color = "amarillo";
            }
            else
            {
                color = "apagado";
            }
        }
    }

    public void estadoNormalSemaforo()
    {
        if (!intermitenteEstado)
        {
            if (color == "rojo" && tiempo > 30)
            {
                color = "rojo + amarillo";
                tiempo = 0;
            }
            else if (color == "rojo + amarillo" && tiempo > 2)
            {
                color = "verde";
                tiempo = 0;
            }
            else if (color == "verde" && tiempo > 20)
            {
                color = "amarillo";
                tiempo = 0;
            }
            else if (color == "amarillo" && tiempo > 2)
            {
                color = "rojo";
                tiempo = 0;
            }
        }
    }
}
