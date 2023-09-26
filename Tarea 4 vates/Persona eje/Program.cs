using System.Numerics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Personas
{

    public class Program
    {

        public static void Main()
        {

            // Cargar por teclado personas
            // Fin de la carga con documento 0
            // Mostrar el toString de la de mayor edad


            // Modificarlo para que lea las personas desde el csv
            // Si hay empate con la mayor edad, tratar de buscar la
            // que quede al último en el diccionario, por apellido y nombre.


            List<Persona> personas = new List<Persona>();

            using (StreamReader lector = new StreamReader(@"personas.csv")){
                string line;
                while ((line = lector.ReadLine()) != null){
                    string[] campos = line.Split(',');
                    string nombre = campos[0];
                    string apellido = campos[1];
                    int edad = int.Parse(campos[2]);

                    Persona persona = new Persona(nombre,apellido,edad);
                    personas.Add(persona);
                }
            }

            int opcion;
            do
            {
                System.Console.WriteLine(" Menu de Personas ");
                System.Console.WriteLine("1. Listar personas por su Apellido");
                System.Console.WriteLine("2. Listar personas por su rango de Edad");
                System.Console.WriteLine("3. Listar personas por su secuencia de numeros en documento");
                System.Console.WriteLine("0. Salir");
                System.Console.WriteLine("Ingrese una opcion");
                
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                    System.Console.WriteLine("Ingrese un apellido: ");
                    string apellido = Console.ReadLine();
                    List<Persona> ApeXUsuario = personas.Where(p => p.Apellido == apellido).ToList();
                    break;
                    case 2:
                    System.Console.WriteLine("Ingrese rango de edad (menor y mayor separado por coma) ");
                    string[] rangoEdad = Console.ReadLine().Split(',');
                    int edadMenor = int.Parse(rangoEdad[0]);
                    int edadMayor = int.Parse(rangoEdad[1]);
                    List<Persona> RangoEdadXusuario = personas.Where(p => p.Edad >= edadMenor && p.Edad <= edadMayor).ToList();
                    break;
                    case 3:
                    System.Console.WriteLine("Ingrese la secuencia de documentos: ");
                    string secuenciaDeDocumentos = Console.ReadLine();
                    List<Persona> DocumentoBuscadoXUsuario = personas.Where(p => p.Documento.EndsWith()(secuenciaDeDocumentos)).ToList();
                    break;
                    case 0:
                    System.Console.WriteLine("Saliendo del programa");
                    break;
                    default:
                    System.Console.WriteLine("Ingrese una opcion valida: ");
                    break;
                }
            } while (opcion != 0);

            System.Console.WriteLine("Criterio de ordenamiento: ");
            System.Console.WriteLine("1. documento ");
            System.Console.WriteLine("2. Apellido + Nombre ");
            System.Console.WriteLine("3. Edad ");
            System.Console.WriteLine("Ingrese una opcion: ");

            int criterioDeOrdenamiento = int.Parse(Console.ReadLine());

            System.Console.WriteLine("1. Direccion creciente");
            System.Console.WriteLine("2. Direccion decreciente");
            System.Console.WriteLine("Ingrese una opcion: ");

            int direccionCrecimiento = int.Parse(Console.ReadLine());

             switch (criterioDeOrdenamiento)
             {
                case 1:
                if (direccionCrecimiento == 1)
                {
                    
                }
             }
        }
    }
}