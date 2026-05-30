using System;

public abstract class CuentaBancaria
{
    protected int saldo_inicial;

    public CuentaBancaria(int saldo_inicial)
    {
        this.saldo_inicial = saldo_inicial;
    }

    public void depositar(int saldo_depositado)
    {
        if (saldo_depositado > 0)
            saldo_inicial += saldo_depositado;
        else
            Console.WriteLine("El saldo es menor o igual a 0");
    }

    public void mostrarSaldo()
    {
        Console.WriteLine("El saldo es de " + saldo_inicial + "$");
    }

    public abstract bool extraer(int monto);
}