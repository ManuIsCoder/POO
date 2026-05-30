using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Triangulo : IForma
    {
        private float alturaTriangulo { get; set; }
        private float baseTriangulo { get; set; }
        private float lado1 { get; set; }
        private float lado2 { get; set; }
        private float lado3 { get; set; }

        public Triangulo(float baseTriangulo, float alturaTriangulo, float lado1, float lado2, float lado3)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public float CalcularArea()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }

        public float CalcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Triangulo: Área = {CalcularArea()}, Perímetro = {CalcularPerimetro()}");
        }
    }
}
