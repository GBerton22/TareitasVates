using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Diccionario
{
  internal class Program
  {
    // HashSet<string> leeQuijote = LeerQuijote();
    // HashSet<string> leeDicIng = LeerDicIngles();
    // HashSet<string> leeQuijote = LeerQuijote();
    static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Mostrar palabras unicas de Quijote");
        Console.WriteLine("2. Mostrar palabras del diccionario");
        // Console.WriteLine("2. Mostrar apellidos sin repetir");
        // Console.WriteLine("3. Mostrar Nombres Repetidos");
        // Console.WriteLine("4. Mostrar Apellidos Repetidos");
        string opcion = Console.ReadLine();



        switch (opcion)
        {
          case "1":
            CantidadPalabrasUnicas();
            break;
          case "2":
            LeerDicIngles();
            break;
          default:
            Console.WriteLine("Opción no válida");
            break;
        }
      }
    }

    public static HashSet<string> LeerQuijote()
    {
      HashSet<string> LectorQ = new HashSet<string>();
      try
      {
        using (StreamReader reader = new StreamReader("Quijote.txt"))
        {
          string quijoteText = reader.ReadToEnd();
          Console.WriteLine(quijoteText);
          LectorQ.Add(quijoteText);
        }
      }

      catch (Exception ex)
      {
        Console.WriteLine("Error al leer los archivos: " + ex.Message);
      }
      return LectorQ;

    }

    public static void CantidadPalabrasUnicas()
    {
      try
      {
        // Leer Quijote.txt
        using (StreamReader reader = new StreamReader("Quijote.txt"))
        {
          string quijoteText = reader.ReadToEnd();

          // Eliminar todos los caracteres no alfabéticos
          quijoteText = Regex.Replace(quijoteText, "[^a-zA-Z ]", "");

          // Dividir el texto en palabras
          string[] words = quijoteText.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

          // Usar un Dictionary para contar la frecuencia de cada palabra
          Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

          foreach (string word in words)
          {
            if (wordFrequency.ContainsKey(word))
            {
              wordFrequency[word]++;
            }
            else
            {
              wordFrequency[word] = 1;
            }
          }

          // Mostrar la cantidad de palabras que se repiten
          int repeatedWordsCount = 0;

          foreach (KeyValuePair<string, int> entry in wordFrequency)
          {
            if (entry.Value > 1)
            {
              repeatedWordsCount++;
            }
          }

          Console.WriteLine("Cantidad de palabras que se repiten en Quijote.txt: " + repeatedWordsCount);
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine("Error al leer el archivo: " + ex.Message);
      }
    }
    public static void LeerDicIngles()
    {
      try
      {
        using (StreamReader reader = new StreamReader("words_alpha.txt"))
        {
          string words_alpha = reader.ReadToEnd();
          string[] words = words_alpha.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
          System.Console.WriteLine($"Cantidad de palabras en el diccionario {words.Length}");
        }

      }

      catch (Exception ex)
      {
        Console.WriteLine("Error al leer los archivos: " + ex.Message);
      }

    }
  }
}
// Tomando el texto del libro "El Quijote de La Mancha" y el diccionario del idioma inglés calcular e informar

// Cantidad de palabras únicas (sin repetición) del libro.
// Cantidad de palabras del diccionario.
// Cantidad de palabras del libro que no existen en el diccionario.
// Listado ordenados de todas las palabras que no existen.