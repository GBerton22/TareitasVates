namespace Clase_4
{
  internal class program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("¡Bienvenido a este ascensor");
      
      Ascensor ascensor = new Ascensor(10);
      ascensor.Desplazar(5);
      Console.WriteLine(ascensor.SubirPersonas(5));
      Console.WriteLine(ascensor.BajarPersonas(3));
      Console.WriteLine(ascensor);
    }
  }
}