using System;

public class Auto : IVehiculo
{
    private int distancia = 0;
    private int velocidadMaxima;

    public Auto(){
        velocidadMaxima = 40;
    }
    public Auto(int velocidadMaxima){
        this.velocidadMaxima = velocidadMaxima;
    }
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
