namespace EMPLEADOS
{
  public class Administrativo : Empleado
  {
    public bool Presentismo { get; set; }

    public Administrativo(int legajo,string nombre, decimal sueldo, bool presentismo) 
                : base(legajo,nombre,sueldo)
    {
      Presentismo = presentismo;
    }

    //cobra un monto fijo por mes más un 13 % si cumplió con el presentismo.
    public override decimal SueldoFinal()
    {
      decimal SueldoMensual = Sueldo / 22 * 20;
      return Presentismo ? SueldoMensual * 1.13m: SueldoMensual;
    }
  }
}