namespace ASCENSOR
{
    class program
    {
        public static void Main(string[] args)
        {

            Ascensor ascensor = new Ascensor(10, 1, -2, 10);
            System.Console.WriteLine("Bienvenidos al Ascensor!! ");

            int personasSubidas = ascensor.SubirPersonas(5);
            System.Console.WriteLine($"Se subieron {personasSubidas} personas ");

            int pisoAlcanzado = ascensor.irAPiso(3);
            System.Console.WriteLine($"Ascensor en piso {pisoAlcanzado}. ");

            int personasBajadas = ascensor.BajarPersonas(3);
            System.Console.WriteLine($"Se bajaron {personasBajadas} personas");

            System.Console.WriteLine(ascensor.InformarString());


        }

    }
}
