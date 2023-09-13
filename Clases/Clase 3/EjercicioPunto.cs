using System.Reflection.Metadata.Ecma335;

namespace Clase_3
{
    public record Punto(double X, double Y)
    {
        public int Cuadrante
        {
            get => (X > 0, Y > 0) switch

            {

                (true,true) => 1,

                (false,true) => 2,

                (true,false) => 4,

                _ => 3
            };
        }
        public double DistanciaAlOrigen
        {
            get  => Math.Sqrt(X*X + Y*Y);
        }
        public double DistanciaOtroPunto(Punto punto)
        {
            return Math.Sqrt(Math.Pow(punto.X - X,2)+Math.Pow(punto.Y - Y,2));
        }
    }
}
// Crear una clase Punto que represente un punto en el plano (X,Y),

//que ofrezca la posibilidad de calcular: -Cuadrante, -Distancia al origen, -Distancia a otro punto.

// Investigar que el cuadrante devuelva un enum

// Investigar como programar el calculo del cuadrante con pattern matching