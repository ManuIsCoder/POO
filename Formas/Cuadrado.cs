using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Cuadrado : IForma
    {
        private float lado;
        public float Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public Cuadrado(float lado)
        {
            this.lado = lado;
        }
        public virtual float CalcularArea()
        {
            return lado * lado;
        }
        public virtual float CalcularPerimetro()
        {
            return 4 * lado;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"{this.GetType().Name}: Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}");
        }
    }
}
