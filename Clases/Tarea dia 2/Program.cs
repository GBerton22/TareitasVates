﻿// Ingresar un conjunto de temperaturas, finalizar la carga cuando se reciba un 1000.
    // Sólo aceptar temperaturas entre -20 y 50 grados.
    // Cantidad de días con temperatura bajo cero
    // Promedio de temperaturas
    // Promedio de temperaturas de los días cálidos, es decir con temp. mayor a 20
    // Mostrar "Si" o "No" para indicar si hubo algún día con más de 40 grados.
    // La mayor temperatura de los días que no fueron cálidos
  internal class Program
    {
        private static void Main(string[] args)
        {

          
    // List<int> Temperaturas = new List<int>();
    // int CantidadTBajoCero = 0;
    // int DiasCalidos = 0; 
    // int DiasNoCalidos = 0;
    // bool DiasMas40Grados = false;
    // int MayorTNoCalidos = 0;

    // Console.WriteLine("<<<<<<<<<<>>>>>>>>>><<<<<<<<<<>>>>>>>>>>");
    // Console.WriteLine("<       Registro de Temperaturas       >");
    // Console.WriteLine("<<<<<<<<<<>>>>>>>>>><<<<<<<<<<>>>>>>>>>>");
    
  
    //     Console.WriteLine("Ingrese las temperaturas (entre -20 y 50) o ingrese 1000 para cerrar! \n ");
    // while (true)
    // {
        
    //     Console.WriteLine("Temperaturas: ");
    //     int temperatura = int.Parse(Console.ReadLine());
        
    //     if (temperatura == 1000)
    //     break;

    //     if (temperatura > -19 && temperatura < 51)
    //     {
    //         Temperaturas.Add(temperatura);

    //         if (temperatura < 0)
    //         CantidadTBajoCero++;

    //         if(temperatura > 20)
    //         DiasCalidos += temperatura;

    //         if (temperatura < 20 && temperatura > 0)
    //         DiasNoCalidos++;

    //         if (temperatura > 40)
    //         DiasMas40Grados = true;

    //         if(temperatura > MayorTNoCalidos && temperatura <= 20)
    //         MayorTNoCalidos = temperatura;
    //     }

    //     else
    //     {
    //         Console.WriteLine("Temperatura fuera del rango (-20, 50)");
    //     }
    // } 

    // Console.Clear();

    // Console.WriteLine("<<<<<<<<<<>>>>>>>>>><<<<<<<<<<>>>>>>>>>>");
    // Console.WriteLine("<             |Resultados|             >");
    // Console.WriteLine("<<<<<<<<<<>>>>>>>>>><<<<<<<<<<>>>>>>>>>>");

    // if(Temperaturas.Count > 20)
    // {
    //     double promedioDiasCalidos = Temperaturas.Average();
    //     Console.WriteLine($"Promedio de todas las temperaturas calidas: {promedioDiasCalidos}");
    // }
    // if (Temperaturas.Count > 0)
    // {
    //     double promedioTemperaturas = Temperaturas.Average();
    //     Console.WriteLine($"Promedio de todas las temperaturas: {promedioTemperaturas}");
    // }
    

    //     Console.WriteLine($"Cantidad de dias bajo cero: {CantidadTBajoCero}");
    //     Console.WriteLine("¿Hubo algún día con más de 40 grados? " + (DiasMas40Grados ? "Si" : "No"));
        
    // if(MayorTNoCalidos > int.MinValue)
    // {
    //     Console.WriteLine($"La mayor temperatura de los dias no calidos son: {MayorTNoCalidos}\n");
    // }
    // else
    // {
    //     Console.WriteLine("No hubo dias que no fueron calidos.");
    // }
    //     Console.WriteLine("Gracias por usar nuestro Registro de Temperaturas!!");
    //     Console.Read();
      
    // // Escribir un programa que muestre en pantalla los números del 1 al 100, 
    // // sustituyendo los múltiplos de 3 por la palabra “fizz”, 
    // // los múltiplos de 5 por “buzz” y los múltiplos de ambos, es decir, 
    // // los múltiplos de 3 y 5 (o de 15), por la palabra “fizzbuzz”.


    // Console.WriteLine("------Ejercicio Fizz Buzz------");
    // Console.WriteLine("Cada multiplo de 3 se cambia por Fizz!");
    // Console.WriteLine("Cada multiplo de 5 se cambia por Buzz!");
    // Console.WriteLine("Cada multiplo de 3 y 5 se cambia por FizzBuzz!\n");

    // for (int i = 1; i < 101; i++)
    // {
    //     if (i%3 == 0 && i%5 == 0)
    //     {
    //         Console.Write("FizzBuzz \n ");
    //     }
    //     else if (i%3 == 0)
    //     {
    //         Console.Write("Fizz ");
    //     }
    //     else if (i%5 == 0)
    //     {
    //         Console.Write("Buzz ");
    //     }
    //     else
    //     {
    //         Console.Write($"{i} ");
    //     }
        
    // }
    // Console.ReadLine();
     for(int i = 0; i < 101; ++i) {
            Console.WriteLine(GetOutputString(i));
        }
    }
    static string GetOutputString(int i) {
        return (i%3, i%5) switch
        {
            (0, 0) => "FizzBuzz",
            (0, _) => "Fizz",
            (_, 0) => "Buzz",
            (_,_) => i.ToString()
        };
      }
        
        
    }