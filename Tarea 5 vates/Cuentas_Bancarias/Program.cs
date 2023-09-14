namespace Cuentas_Bancarias
{
    class program
    {
        static void Main(string[] args)
        {
            List<Cuenta> cuentas = new List<Cuenta>
        {
             new CajaDeAhorro(1, "Juan", 1000m),
             new CuentaCorriente(2, "Ana", 2000m, 500m)
        };

            cuentas[0].Depositar(500m);
            bool resultado = cuentas[1].Extraer(2500m);

            foreach (Cuenta cuenta in cuentas)
            {
                Console.WriteLine($"Número: {cuenta.Numero}, Nombre: {cuenta.Nombre}, Saldo: {cuenta.GetSaldo()}");
            }

        }
    }
}