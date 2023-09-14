namespace EMPLEADOS
{
  public class Vendedor : Empleado
  {
    public int Ventas { get; set; }

    public Vendedor(int legajo,string nombre, decimal sueldo, int ventas) 
                : base(legajo,nombre,sueldo)
    {
      Ventas = ventas;
    }

    //cobra un monto fijo por mes más una comisión de 1 % del total de sus ventas.
    public override decimal SueldoFinal()
    {
      decimal SueldoMensual = Sueldo / 22 * 20;
      SueldoMensual =+ Ventas * 0.01m;
      return SueldoMensual;
      
    }
  }
}