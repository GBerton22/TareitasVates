namespace Empleados
{
    public class Administrativo : Empleado
{
    public bool Presentismo { get; set; }

    public Administrativo(int legajo, string nombre, decimal sueldoBasico, bool presentismo)
        : base(legajo, nombre, sueldoBasico)
    {
        Presentismo = presentismo;
    }

    public override decimal CalcularSueldoNeto()
    {
        decimal sueldoMensual = SueldoBasico / 22 * 20;
        return Presentismo ? sueldoMensual * 1.13m : sueldoMensual;
    }
}

}