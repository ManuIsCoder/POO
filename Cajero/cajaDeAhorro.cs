using System;

public class CajaDeAhorro : CuentaBancaria{
    public CajaDeAhorro(int saldoInicial) : base(saldoInicial){}

    public override bool extraer(int monto){
        if (monto < 0){
            Console.WriteLine("No se permite extraer negativo");
            return false;
        }
        else{
            if(monto <= saldo_inicial){
                saldo_inicial -= monto;
                return true;
            }
            else{
                Console.WriteLine("Esta intentando extraer mas de la cantidad que tiene");
                return false;
            }
        }
    }
}