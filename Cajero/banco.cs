using System.Collections.Generic;
using System;

public class Banco {
    private List<CuentaBancaria> cuentas = new List<CuentaBancaria>();
    public void agregarCuenta(CuentaBancaria cuenta){
        cuentas.Add(cuenta);
    }
    public void transferir(CuentaBancaria origen, CuentaBancaria destino, int monto){
        if(cuentas.Contains(origen) && cuentas.Contains(destino) && monto>=0){
            if(origen.extraer(monto))
                destino.depositar(monto);
            else
                Console.WriteLine("No se puede extraer dinero de la cuenta origen");
        }
        else
            Console.WriteLine("Alguna cuenta no existe o el monto es negativo");
    }
}