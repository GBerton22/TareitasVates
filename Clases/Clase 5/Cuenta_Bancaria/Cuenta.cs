namespace CUENTA_BANCARIA
{
  public abstract class cuenta
  {
    public int Numero { get; set; }
    public string Nombre { get; set; }
    public decimal Saldo { get; set; }

    public cuenta(int numero, string nombre, decimal saldo)
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
    public decimal ObtenerSaldo()
    {
      return Saldo;
    }

  }
}