using System;

public class Camion : IVehiculo
{
    private int distancia = 0;
    private const int velocidadMaxima = 30;

    public void mover(int tiempo){
        distancia += velocidadMaxima * tiempo;
    }
    public int posicion(){
        return distancia;
    }
    public void reiniciarPosicion(){
        distancia = 0;
    }
}
