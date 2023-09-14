namespace Cuentas_Bancarias
{
    public class CuentaCorriente : Cuenta
{
    public decimal Acuerdo { get; set; }

    public CuentaCorriente(int numero, string nombre, decimal saldo, decimal acuerdo)
        : base(numero, nombre, saldo)
    {
        Acuerdo = acuerdo;
    }

    public override bool Extraer(decimal monto)
    {
        if (Saldo + Acuerdo >= monto)
        {
            Saldo -= monto;
            return true;
        }

        return false;
    }
}

}