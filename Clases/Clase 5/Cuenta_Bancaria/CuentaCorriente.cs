namespace CUENTA_BANCARIA
{
  public class CuentaCorriente : cuenta
  {
    public decimal Acuerdo { get; set; }
    public CuentaCorriente(int numero, string nombre, decimal saldo, decimal acuerdo) : base(numero, nombre, saldo)
    {
      Acuerdo = acuerdo;
    }

    //Las cuentas corrientes poseen un atributo “acuerdo” que indica el máximo saldo negativo admisible
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