using System;

public class Bicicleta : IVehiculo
{
    private int distancia = 0;
    private const int velocidadMaxima = 10;

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