namespace Cuentas_Bancarias
{
 public class CajaDeAhorro : Cuenta
{
    public CajaDeAhorro(int numero, string nombre, decimal saldo)
        : base(numero, nombre, saldo)
    {
    }

    public override bool Extraer(decimal monto)
    {
        if (Saldo >= monto)
        {
            Saldo -= monto;
            return true;
        }

        return false;
    }
}

}