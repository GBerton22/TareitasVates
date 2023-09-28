namespace Veterinaria2_0
{
  public class AtencionMedica : Atencion
  {
    public Mascota Mascota { get; set; }
    public decimal ImporteConsulta { get; set; }
    public TipoCobro TipoCobro { get; set; }
    public AtencionMedica() : base()
    {
      
    }
    public AtencionMedica(int cobro, Mascota mascota,decimal importeConsulta,TipoCobro tipoCobro) 
    : base(cobro)
    {
      Mascota = mascota;
      ImporteConsulta = importeConsulta;
      TipoCobro = tipoCobro;    
    }
    public override decimal ImporteACobrar()
    {
      //Importe consulta
      ImporteTotal = Mascota.EsHabitual ? ImporteConsulta *= 0.75m : ImporteConsulta;
        switch (TipoCobro)
        {
            case TipoCobro.Efectivo:
                ImporteTotal *= 0.90m;
                break;
            case TipoCobro.TarjetaCredito:
                ImporteTotal *= 1.20m;
                break;
        }

        return ImporteTotal;
    }

  }
}