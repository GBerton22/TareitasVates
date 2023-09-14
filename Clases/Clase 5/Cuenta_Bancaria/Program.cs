namespace CUENTA_BANCARIA
{
  class program
  {
    static void Main(string[] args)
    {
      List<cuenta> cuentas = new List<cuenta>
      {
         new CuentaCorriente(1,"Marcelo",2000m,500m),
         new CajaAhorro(2,"Julio",1000m),
         new CuentaCorriente(3,"Mario",1000m,700m),
         new CajaAhorro(4,"Maria",1000m),
         new CuentaCorriente(5,"Lucia",1000m,1500m),
         new CajaAhorro(6,"Daniel",1000m),
         new CuentaCorriente(7,"Jacinto",1000m,500m),
         new CajaAhorro(8,"Juliana",1000m)
      };
      cuentas[0].Depositar(500m);
      cuentas[1].Extraer(2500m);
      cuentas[2].Depositar(200m);
      cuentas[3].Extraer(600m);
      cuentas[4].Depositar(423m);
      cuentas[5].Extraer(402m);
      cuentas[6].Depositar(1522m);
      cuentas[7].Extraer(1000m);
      System.Console.WriteLine("Visualiza los datos de su cuenta aqui...");
      foreach (cuenta c in cuentas)
      {
        System.Console.WriteLine($"Numero {c.Numero}, Nombre {c.Nombre} y Saldo {c.Saldo} ");
      }
      System.Console.WriteLine("Gracias! ");
    }
  }
}