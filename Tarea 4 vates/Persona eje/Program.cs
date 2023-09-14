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

            string[] lines = File.ReadAllLines(@"personas.csv");
            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                int documento = int.Parse(data[0]);
                string nombre = data[1];
                string apellido = data[2];
                int edad = int.Parse(data[3]);

                Persona p = new Persona(documento, nombre, apellido, edad);
                personas.Add(p);
            }
            var orderedByAgeAndName = personas.OrderByDescending(p => p.Edad)
                                    .ThenBy(p => p.Apellido)
                                    .ThenBy(p => p.Nombre)
                                    .ToList();

            Persona lastOldest = orderedByAgeAndName.LastOrDefault();

            if (lastOldest != null)
            {
                Console.WriteLine("La persona mayor que queda al último en el diccionario es: " + lastOldest);
            }
            else
            {
                Console.WriteLine("No hay una persona mayor que queda al último en el diccionario");
            }

            var orderedByAge = personas.OrderByDescending(p => p.Edad).ToList();
            int oldestAge = orderedByAge.First().Edad;
            Persona nextOldest = orderedByAge.SkipWhile(p => p.Edad == oldestAge).FirstOrDefault();

            if (nextOldest != null)
            {
                Console.WriteLine($"La siguiente persona más vieja es: {nextOldest}");
            }
            else
            {
                Console.WriteLine("No hay una siguiente persona más vieja");
            }

        }
    }
}