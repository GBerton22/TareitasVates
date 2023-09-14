namespace Empleados
{
    public abstract class Empleado
{
    public int Legajo { get; set; }
    public string Nombre { get; set; }
    public decimal SueldoBasico { get; set; }

    public Empleado(int legajo, string nombre, decimal sueldoBasico)
    {
        Legajo = legajo;
        Nombre = nombre;
        SueldoBasico = sueldoBasico;
    }

    public abstract decimal CalcularSueldoNeto();
}

}