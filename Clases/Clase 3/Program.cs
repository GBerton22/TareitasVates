namespace Clase_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double x,y;

            int opc;

            Console.WriteLine("Ingrese el valor de X");

            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de Y");

            y = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese que operación quiere valor quiere obtener \n 1) Obtiene el cuadrante \n 2) Obtiene la distancia al origen \n 3) Obtiene la distancia con otro punto");

            opc = int.Parse(Console.ReadLine());
            Punto punto = new Punto(x,y);
            switch (opc)
            {
                case 1: Console.WriteLine($"El cuadrante es {punto.Cuadrante}");
                break;
                case 2: Console.WriteLine($"La distancia al origen es de {punto.DistanciaAlOrigen}");
                break;
                case 3:
                Console.WriteLine("Ingrese X del nuevo punto");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Y del nuevo punto");
                y = double.Parse(Console.ReadLine());
                Punto punto2 = new Punto(x,y);
                Console.WriteLine($"La distancia entre el primer punto y el segundo punto es de {punto.DistanciaOtroPunto(punto2)}");
                break;
                default:
                break;
            }
        }
    }
}