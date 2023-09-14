namespace Empleados
{
   public class Obrero : Empleado
{
    public int DiasTrabajados { get; set; }

    public Obrero(int legajo, string nombre, decimal sueldoBasico, int diasTrabajados)
        : base(legajo, nombre, sueldoBasico)
    {
        DiasTrabajados = diasTrabajados;
    }

    public override decimal CalcularSueldoNeto()
    {
        return SueldoBasico / 22 * DiasTrabajados;
    }
}
 
}