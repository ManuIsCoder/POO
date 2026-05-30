using System;

class Program
{
    static void Main(string[] args)
    {
        CajaDeAhorro ahorro = new CajaDeAhorro(1000);

        ahorro.depositar(1000);
        ahorro.extraer(400);
        ahorro.extraer(800); // debe rechazarse
        ahorro.mostrarSaldo(); // debe mostrar 600

        CuentaCorriente corriente = new CuentaCorriente(500);

        corriente.depositar(200);
        corriente.extraer(600); // queda en -400, es valido
        corriente.extraer(200); // supera el descubierto, debe rechazarse
        corriente.mostrarSaldo(); // debe mostrar -400
    }
}