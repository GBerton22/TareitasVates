namespace Clase_4
{
    using System;
    using System.Runtime.InteropServices;

    // Un ascensor posee una capacidad máxima de n personas y 
    // está instalado en un edificio cuyos pisos se encuentran numerados.
    // Se necesita desarrollar una clase Ascensor 
    // que represente el funcionamiento del mismo.

    // Desplazarse a un piso determinado
    // Subir personas
    // Bajar personas
    // Informar el piso donde se encuentra y 
    // la cantidad de personas que hay adentro


    public class Ascensor
    {
        public int Capacidad { get; set; } //Capcadidad del ascensor
        public int PisoActual { get; private set; } // Piso actual del ascensor
        public int PersonasDentro { get; private set; } //Personas dentro del ascensor

        public Ascensor(int capacidad)
        {
            Capacidad = capacidad;
            PisoActual = 0;
            PersonasDentro = 0;
        }

        public bool Desplazar(int pisoDestino)
        {
            if (pisoDestino < -2 && pisoDestino > 10){
                Console.WriteLine("El piso esta fuera de rango...");
                return false;
            }
            else if(pisoDestino >= -2 && pisoDestino <= 11)
            {
            PisoActual = pisoDestino;
            }
            return true;
        }

        public int SubirPersonas(int cantidad)
        {
            if (cantidad < 0)
                return -1;

            int personasSubidas = Math.Min(cantidad, Capacidad - PersonasDentro);
            PersonasDentro += personasSubidas;
            return personasSubidas;
        }

        public int BajarPersonas(int cantidad)
        {
            if (cantidad < 0)
                return -1;

            int personasBajadas = Math.Min(cantidad, PersonasDentro);
            PersonasDentro -= personasBajadas;
            return personasBajadas;
        }

        public int CantEsperada(int cantidad)
        {
            if(Capacidad > PersonasDentro)
            {
                cantidad += PersonasDentro;
            }
            return cantidad;
        }

        public override string ToString()
        {
            return $"Piso: {PisoActual}, Personas: {PersonasDentro}";
        }

        // public enum Movimiento
        // {
        //     Sub_II,
        //     Sub_I,
        //     Cero,
        //     I,
        //     II,
        //     III,
        //     IV,
        //     V,
        //     VI,
        //     VII,
        //     VIII,
        //     IX,
        //     X,
        //     Error
        // }
        // public Movimiento movimiento()
        // {
        //     return PisoActual switch
        //     {
        //         0 => Movimiento.Sub_II,
        //         1 => Movimiento.Sub_I,
        //         2 => Movimiento.Cero,
        //         3 => Movimiento.I,
        //         4 => Movimiento.II,
        //         5 => Movimiento.III,
        //         6 => Movimiento.IV,
        //         7 => Movimiento.V,
        //         8 => Movimiento.VI,
        //         9 => Movimiento.VII,
        //         10 => Movimiento.VIII,
        //         11 => Movimiento.IX,
        //         12 => Movimiento.X,
        //         _ => Movimiento.Error
        //     };
        // }
    }
}