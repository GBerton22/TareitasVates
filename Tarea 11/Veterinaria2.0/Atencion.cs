namespace Veterinaria2_0
{
  public abstract class Atencion
  {
    public int Codigo { get; set; }
    public enum TipoCobro { Efectivo = 1,
                            TarjetaCredito = 2 } //1-Efectivo, 2-TarjetaCredito
    public decimal ImporteTotal { get; set; }

    public Atencion()
    {
      
    }
    public Atencion(int codigo)
    {
      Codigo = codigo;
    }
   public abstract decimal ImporteACobrar();
  }
}