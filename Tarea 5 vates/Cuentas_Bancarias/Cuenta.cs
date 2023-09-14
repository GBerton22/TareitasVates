namespace Cuentas_Bancarias
{
    public class Cuenta
{
    public int Numero { get; set; }
    public string Nombre { get; set; }
    protected decimal Saldo { get; set; }

    public Cuenta(int numero, string nombre, decimal saldo)
    {
        Numero = numero;
        Nombre = nombre;
        Saldo = saldo;
    }

    public void Depositar(decimal monto)
    {
        Saldo += monto;
    }

    public virtual bool Extraer(decimal monto)
    {
        if (Saldo >= monto)
        {
            Saldo -= monto;
            return true;
        }

        return false;
    }

    public decimal GetSaldo()
    {
        return Saldo;
    }
}

}