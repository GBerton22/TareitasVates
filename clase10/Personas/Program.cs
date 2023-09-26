namespace CollecionesPersona
{
  public class Program
  {

    static void Main(string[] args)
    {
      HashSet<Persona> personas = CargarPersonas();
      while (true)
      {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Mostrar nombres sin repetir");
        Console.WriteLine("2. Mostrar apellidos sin repetir");
        Console.WriteLine("3. Mostrar Nombres Repetidos");
        Console.WriteLine("4. Mostrar Apellidos Repetidos");
        string opcion = Console.ReadLine();



        switch (opcion)
        {
          case "1":
            var nombresSinRepetir = personas.Distinct(new ComparadorNombre());
            foreach (var persona in nombresSinRepetir)
            {
              Console.WriteLine(persona.Nombre);
            }
            break;
          case "2":
            var apellidosSinRepetir = personas.Distinct(new ComparadorApellido());
            foreach (var persona in apellidosSinRepetir)
            {
              Console.WriteLine(persona.Apellido);
            }
            break;
          case "3":
            InformarPersonasMisNom(personas);
            break;
          case "4":
            InformarPersonasMisApe(personas);
            break;
          default:
            Console.WriteLine("Opción no válida");
            break;
        }
      }
    }

    public static HashSet<Persona> CargarPersonas()
    {
      HashSet<Persona> personas = new HashSet<Persona>();

      using (StreamReader lector = new StreamReader(@"personas.csv"))
      {
        string line;
        while ((line = lector.ReadLine()) != null)
        {
          string[] campos = line.Split(',');
          int documento = int.Parse(campos[0]);
          string nombre = campos[1];
          string apellido = campos[2];
          int edad = int.Parse(campos[3]);
          Persona persona = new Persona(nombre, apellido, edad);
          // SrtPer.Add(persona);
          personas.Add(persona);
        }
      }

      return personas;
    }

    public static void InformarPersonasMisNom(HashSet<Persona> personas)
    {
      var nombres = new Dictionary<string, int>();
      foreach (var persona in personas)
      {
        if (nombres.ContainsKey(persona.Nombre))
        {
          nombres[persona.Nombre]++;
        }
        else
        {
          nombres[persona.Nombre] = 1;
        }
      }
      foreach (var nombre in nombres)
      {
        if (nombre.Value > 1)
        {
          Console.WriteLine($"El nombre {nombre.Key} se repite {nombre.Value} veces.");
        }
      }
    }
    public static void InformarPersonasMisApe(HashSet<Persona> personas)
    {
      var apellidos = new Dictionary<string, int>();
      foreach (var persona in personas)
      {
        if (apellidos.ContainsKey(persona.Apellido))
        {
          apellidos[persona.Apellido]++;
        }
        else
        {
          apellidos[persona.Apellido] = 1;
        }
      }
      foreach (var apellido in apellidos)
      {
        if (apellido.Value > 1)
        {
          Console.WriteLine($"El nombre {apellido.Key} se repite {apellido.Value} veces.");
        }
      }
    }
  }
}
//- cargar csv personas y listar todos los apellidos sin repeticiones 
// - otro listado solo los nombres sin repeticiones 
// - metodo informar si hay PersonasIgualNombre y igual PersonasIgualApellido