namespace Veterinaria2_0
{
  public class Mascota
  {
    public int Codigo { get; set; } //unico para cada mascota
    public string Nombre { get; set; }
    public int Especie { get; set; }
    public bool EsHabitual { get; set; } //true false

    public Mascota()
    {
      
    }

    public Mascota(int codigo, string nombre, bool esHabitual)
    {
      Codigo = codigo;
      Nombre = nombre;
      EsHabitual = esHabitual;
    }

    


  }
}