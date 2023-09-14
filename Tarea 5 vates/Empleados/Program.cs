namespace Empleados
{
    class Program
{
    static void Main(string[] args)
    {
        decimal sueldoBasico = 30000;

        Obrero obrero = new Obrero(1, "Juan Perez", sueldoBasico, 20);
        Administrativo administrativo = new Administrativo(2, "María García", sueldoBasico, true);
        Vendedor vendedor = new Vendedor(3, "Lucas Rodríguez", sueldoBasico, 100000);

        Console.WriteLine($"Sueldo neto obrero: {obrero.CalcularSueldoNeto()}");
        Console.WriteLine($"Sueldo neto administrativo: {administrativo.CalcularSueldoNeto()}");
        Console.WriteLine($"Sueldo neto vendedor: {vendedor.CalcularSueldoNeto()}");
    }
}

}