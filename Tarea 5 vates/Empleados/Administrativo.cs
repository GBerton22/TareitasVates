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
        return Presentismo ? SueldoBasico * 1.13m : SueldoBasico;
    }
}

}