namespace ASCENSOR
{
    public class Ascensor
    {
        public int Capacidad { get; set; }
        public int PisoActual { get; set; }
        public int Personas { get; set; }
        public int PisoMax { get; set; }
        public int PisoMin { get; set; }

        public Ascensor(int capacidad,int pisoActual, int pisoMax, int pisoMin)
        {
            Capacidad = capacidad;
            PisoActual = pisoActual;
            this.Personas = 0;
            PisoMax = pisoMax;
            PisoMin = pisoMin;
        }

        // public Ascensor(int capacidad)
        // {
        //     Capacidad = capacidad;
        // }

        public int irAPiso(int pisoDeseado)
        {
            int pisoActual = this.PisoActual;
            while(pisoActual != pisoDeseado)
            {
                if(pisoActual < pisoDeseado)
                pisoActual++;
                else
                pisoActual--;
            }
            this.PisoActual = pisoActual;
            return pisoActual;
        }

        public int SubirPersonas (int cantidad)
        {
            int personasSubidas = Math.Min(cantidad, Capacidad - Personas);
            Personas += personasSubidas;
            return personasSubidas;
        }
         public int BajarPersonas (int cantidad)
        {
            int personasBajadas = Math.Min(cantidad, Personas);
            Personas -= personasBajadas;
            return personasBajadas;
        }

        public string InformarString()
        {
            return $"El piso en el que se encuentran es: {PisoActual} y la cantidad de personas a bordo son: {Personas}";
        }

    }

}