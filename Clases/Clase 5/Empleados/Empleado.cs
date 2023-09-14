namespace EMPLEADOS
{
    public abstract class Empleado
    {
      public int Legajo { get; init; }
      public string Nombre { get; set; }
      public decimal Sueldo { get; set; }
      public Empleado(int legajo,string nombre, decimal sueldo)
      {
        Legajo = legajo;
        Nombre = nombre;
        Sueldo = sueldo;
      }

      public abstract decimal SueldoFinal();
    }
}