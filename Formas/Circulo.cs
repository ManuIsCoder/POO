using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Circulo : IForma
    {
        private float radio { get; set; }

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public float CalcularArea()
        {
            return radio * radio * 3.14f;
        }

        public float CalcularPerimetro()
        {
            return 2 * radio * 3.14f;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Circulo: Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}");
        }
    }
}
