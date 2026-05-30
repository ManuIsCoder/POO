using System;
using System.Collections.Generic;

namespace Formas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IForma> formas = new List<IForma>();
            
            formas.Add(new Rectangulo(7, 3));
            formas.Add(new Cuadrado(4));
            formas.Add(new Circulo(5));
            formas.Add(new Triangulo(4, 3, 4, 3, 5));

            foreach (IForma forma in formas)
            {
                forma.MostrarInformacion();
            }
        }
    }
}
