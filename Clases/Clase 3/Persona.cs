public class Persona
{
  //atributos
  //propiedades
  private int documento;
  public int Documento
  {
    get { return documento; }
    init { documento = value; }
  }
  private string nombre;
  public string Nombre
  {
    get { return nombre; }
    set { nombre = value; } 
  } 
  private string apellido;
  public string Apellido
  {
    get { return apellido; }
    set { apellido = value; }
  }
  private int nacimiento;
  public int Nacimiento
  {
    get { return nacimiento; }
    set { nacimiento = value; }
  }
   //constructores
   public Persona()
   {
    
   }
  public Persona(int documento, string nombre, string apellido, int nacimiento)
  {
    this.Documento = documento;
    this.Nombre = nombre;
    this.Apellido = apellido;
    this.Nacimiento = nacimiento;
  }
  //metodos

  public string NombreCompleto()
  {
    return $"{nombre} {apellido}";
  }
}

