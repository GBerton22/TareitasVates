namespace EMPLEADOS
{
  public class Obrero : Empleado
  {
    public int DiasTrabajados { get; set; }

    public Obrero(int legajo,string nombre, decimal sueldo, int diasTrabajados) 
                : base(legajo,nombre,sueldo)
    {
      DiasTrabajados = diasTrabajados;
    }

    public override decimal SueldoFinal()
    {
      Sueldo = Sueldo / 22 * DiasTrabajados;
      return Sueldo;
    }
  }
}
