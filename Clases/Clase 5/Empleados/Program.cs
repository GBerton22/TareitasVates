namespace EMPLEADOS
{
  class program
  {
    static void Main(string[] args)
    {
      Obrero O1 = new Obrero(1123, "Roberto", 1000, 20);
      Administrativo Ad1 = new Administrativo(1123, "Roberto", 1000, true);
      Vendedor V1 = new Vendedor(1123, "Roberto", 1000, 100000);

      System.Console.WriteLine($"El sueldo Final del obrero es de: {O1.SueldoFinal()}");
      System.Console.WriteLine($"El sueldo Final del Administrativo es de: {Ad1.SueldoFinal()}");
      System.Console.WriteLine($"El sueldo Final del Vendedor es de: {V1.SueldoFinal()}");

    }
  }
}