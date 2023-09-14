namespace CUENTA_BANCARIA
{
  public class CajaAhorro : cuenta
  {
    public CajaAhorro(int numero, string nombre, decimal saldo) : base(numero, nombre, saldo)
    {
      Numero = numero;
      Nombre = nombre;
      Saldo = saldo;
    }

    //Las cajas de ahorro no permiten extracciones si el saldo no es suficiente
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