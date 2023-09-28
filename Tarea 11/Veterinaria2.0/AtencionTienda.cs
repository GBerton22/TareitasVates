namespace Veterinaria2_0
{
  public class AtencionTienda : Atencion
  {
    public decimal ImporteTotalArticulos { get; set; }
    public decimal Vale { get; set; }
    public TipoCobro TipoCobro { get; set; }
    //Especifica el monto de descuento que
    // se aplicara al importe total de los articulos
    public AtencionTienda() : base()
    {
      
    }
    public AtencionTienda(int cobro, decimal importeTotalArticulos, decimal vale, TipoCobro tipoCobro)
    : base(cobro)
    {
      ImporteTotalArticulos = importeTotalArticulos;
      Vale = vale;
      TipoCobro = tipoCobro;
    }

    public decimal CalcularImporteCDescuento()
    { //si vale es 0 o mas se realizar el descuento
      if (Vale > 0)
      {
        return ImporteTotalArticulos - Vale;
      }
      else
      {
        return ImporteTotalArticulos;
      }
    }
    public override decimal ImporteACobrar()
    {
      //ImporteTotalArticulos
      ImporteTotal = ImporteTotalArticulos -= Vale;
      switch (TipoCobro)
      {
        case TipoCobro.Efectivo:
          ImporteTotal *= 0.95m;
          break;
        case TipoCobro.TarjetaCredito:
          ImporteTotal *= 1.30m;
          break;

      }
      return ImporteTotal;
    }
  }
}