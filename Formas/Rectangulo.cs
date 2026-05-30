using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    public class Rectangulo : Cuadrado
    {
        private float baseRectangulo { get; set; }
        private float alturaRectangulo { get; set; }

        public Rectangulo(float baseRectangulo, float alturaRectangulo) : base(baseRectangulo)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
        }
        public override float CalcularArea()
        {
            return baseRectangulo * alturaRectangulo;
        }

        public override float CalcularPerimetro()
        {
            return 2 * (baseRectangulo + alturaRectangulo);
        }
    }
}
