using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Veterinaria2_0
{
  public class Veterinaria
  {
    public string RazonSocial { get; set; }
    public HashSet<Atencion> LstAtencion { get; set; }

    public Veterinaria(string razonSocial)
    {
      RazonSocial = razonSocial;
      LstAtencion = new HashSet<Atencion>();
    }

    public void AgregarAtencion(Atencion atencion)
    {
      LstAtencion.Add(atencion);
    }
    public decimal importeTotalGatos()
    {
       return LstAtencion
        .OfType<AtencionMedica>() // DEL TIPO atencionmedica
        .Where(atencion => atencion.Mascota.Especie == 2) //FILTRA las atenciones del tipo gato
        .Sum(atencion => atencion.ImporteTotal); //suma los importes totales de las atenciones
    }
    public int cantidadAtencionesHasta(decimal valorMaximo)
    {
      return LstAtencion
      .Count(atencion => atencion.ImporteTotal > 1000 && atencion.ImporteTotal < valorMaximo);
    }
   public AtencionMedica PrimerAtencionMedicaGato()
{
    return LstAtencion
        .OfType<AtencionMedica>()
        .FirstOrDefault(atencion => atencion.Mascota.Especie == 2) ?? new AtencionMedica();
}
  }
}