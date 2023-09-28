using System.Globalization;

namespace Veterinaria2_0
{
  public class program
  {
    static void Main(string[] args)
    {

      Veterinaria vet = new Veterinaria("Mi Veterinaria beautifull");

      // Cargar las atenciones médicas y de tienda
      List<AtencionMedica> atencionesMedicas = CargarAtencionesMedicas();
      List<AtencionTienda> atencionesTienda = CargarAtencionesTienda();
      // Agregar las atenciones a la veterinaria
      foreach (var atencion in atencionesMedicas)
      {
        vet.AgregarAtencion(atencion);
      }
      foreach (var atencion in atencionesTienda)
      {
        vet.AgregarAtencion(atencion);
      }
      Console.WriteLine($"Importe total para los gatos: {vet.importeTotalGatos():C2}");
      Console.WriteLine($"Cantidad de atenciones hasta $3000: {vet.cantidadAtencionesHasta(3000)}");
      AtencionMedica primeraAtencion = vet.PrimerAtencionMedicaGato();
      if (primeraAtencion != null)
      {
        Console.WriteLine("Primera atención médica a un gato encontrada.");
      }
      else
      {
        Console.WriteLine("No se encontró ninguna atención médica a un gato.");
      }
    }
    public static List<AtencionTienda> CargarAtencionesTienda()
    {
      List<AtencionTienda> LstAT = new List<AtencionTienda>();
      using (StreamReader reader = new StreamReader("AtencionesTienda.csv"))
      {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
          string[] valor = line.Split(",");
          AtencionTienda atencion = new AtencionTienda();
          decimal importeTotalArticulos = Convert.ToDecimal(valor[0],CultureInfo.InvariantCulture);
          decimal vale = Convert.ToDecimal(valor[1]);

          LstAT.Add(atencion);
        }
      }
      return LstAT;
    }
    public static List<AtencionMedica> CargarAtencionesMedicas()
    {
      List<AtencionMedica> LstAM = new List<AtencionMedica>();
      using (StreamReader reader = new StreamReader("AtencionesMedica.csv"))
      {
        string linea;
        while ((linea = reader.ReadLine()) != null)
        {
          string[] valor = linea.Split(",");
          Mascota mascota = new Mascota();
          mascota.Nombre = valor[0];
          mascota.Especie = int.Parse(valor[1]);
          mascota.EsHabitual = (valor[2]) == "1";

          AtencionMedica atencion = new AtencionMedica();
          atencion.Mascota = mascota;
          atencion.Codigo = int.Parse(valor[3]);
          atencion.ImporteTotal = decimal.Parse(valor[4],CultureInfo.InvariantCulture);

          LstAM.Add(atencion);
        }
      }
      return LstAM;
    }
  }
}