namespace Clase_5
{
  public class AtencionFarmacia : Atencion
  {
    public decimal ImporteTotalMedicamentos {get;set;}
    public decimal CuponDescuento { get; set; }

    public AtencionFarmacia(int codigo, int tipoCobro, decimal importeTotal, decimal cuponDescuento)  
    : base(codigo, tipoCobro)
    {
      ImporteTotalMedicamentos = importeTotal;
      CuponDescuento = cuponDescuento;
    }
    public override decimal ImporteACobrar()
    {
      decimal importe = ImporteACobrar - CuponDescuento;
      if (TipoCobro == 2 ) // tarjeta de credito
      {
        importe  *= 1.30m; // m por que es decimal
      }
      else if (TipoCobro == 1){ // efectivo
        importe *= 0.95m;
      }
      return importe;
    }

  }
}