using System;

namespace Jugadores
{
    public class JugadorRangoBajo : IJugadores
    {
        public int tiempo { get; set; }

        public void Correr(int minutos)
        {
            tiempo = Math.Max(0, tiempo - minutos);
        }

        public bool Cansado()
        {
            return tiempo == 0;
        }

        public void Descansar(int minutos)
        {
            tiempo = Math.Min(20, tiempo + minutos);
        }
    }
}