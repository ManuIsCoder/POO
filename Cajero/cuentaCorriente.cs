using System;

public class CuentaCorriente : CuentaBancaria{
    public CuentaCorriente(int saldoInicial) : base(saldoInicial){}
    private int MaxDeuda = -500;
    public override bool extraer(int monto){
        if ((saldo_inicial-monto)<=MaxDeuda){
            Console.WriteLine("Esta intentando extraer mas del limite");
            return false;
        }
        else{
                saldo_inicial -= monto;
                return true;
        }
    }
}