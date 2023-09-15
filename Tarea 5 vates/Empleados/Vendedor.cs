namespace Empleados
{
    public class Vendedor : Empleado
{
    public decimal Ventas { get; set; }

    public Vendedor(int legajo, string nombre, decimal sueldoBasico, decimal ventas)
        : base(legajo, nombre, sueldoBasico)
    {
        Ventas = ventas;
    }

    public override decimal CalcularSueldoNeto()
    {
        return SueldoBasico + Ventas * 0.01m;
    }
}

}