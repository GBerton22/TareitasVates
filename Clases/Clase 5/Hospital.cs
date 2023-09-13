namespace Clase_5
{
  public class Hospital
  {
    public string RazonSocial { get; set; }
    public List<Atencion> Atenciones { get; set; }

    public Hospital(string razonSocial)
    {
      RazonSocial = razonSocial;
      Atenciones = new List<Atencion>();
    }
    public void AddAtencion(Atencion atencion)
    {
      Atenciones.Add(atencion);
    }
    public decimal ImporteACobrarPromedioAtencionesMedicas()
    {
      //promedio de todas las atenciones medicas que se hicieron
      //petterMatching con is 
      List<AtencionesMedicas> atenciones = new List<AtencionesMedicas>();
      foreach (Atencion atencion in Atenciones)
      {
        if (atencion is AtencionMedica)
          Atenciones.Add(atencion);
      }
      if (atenciones.Count() == 0)
        throw new InvalidOperationException("No se han registrado atenciones medicas ");

      decimal sumaImportes = atenciones.Sum(atencion => atencion.CaluclarImporte());
      int cantidadAtenciones = atenciones.Count();
      return sumaImportes / cantidadAtenciones;
    }
  }
}