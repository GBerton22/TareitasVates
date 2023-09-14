namespace PARTIDO
{
    class program
    {
        public static void Main(string[] args)
        {
            Equipo equipo1 = new Equipo { Nombre = "Equipo 1" };
            Equipo equipo2 = new Equipo { Nombre = "Equipo 2" };

            Partido partido1 = new Partido
            {
                EquipoLocal = equipo1,
                EquipoVisitante = equipo2,
                GolesLocal = 2,
                GolesVisitante = 1
            };

            Partido partido2 = new Partido
            {
                EquipoLocal = equipo2,
                EquipoVisitante = equipo1,
                GolesLocal = 1,
                GolesVisitante = 1
            };

            equipo2.RegistrarPartido(partido1);
            equipo2.RegistrarPartido(partido2);

            Console.WriteLine($"Equipo: {equipo1.Nombre}");
            Console.WriteLine($"Partidos jugados: {equipo1.PartidosJugados}");
            Console.WriteLine($"Partidos jugados como local: {equipo1.PartidosJugadosComoLocal}");
            Console.WriteLine($"Partidos jugados como visitante: {equipo1.PartidosJugadosComoVisitante}");
            Console.WriteLine($"Goles realizados: {equipo1.GolesRealizados}");
            Console.WriteLine($"Goles recibidos: {equipo1.GolesRecibidos}");
            Console.WriteLine($"Diferencia de goles: {equipo1.DiferenciaDeGoles}");
            Console.WriteLine($"Partidos ganados: {equipo1.PartidosGanados}");
            Console.WriteLine($"Partidos empatados: {equipo1.PartidosEmpatados}");
            Console.WriteLine($"Partidos perdidos: {equipo1.PartidosPerdidos}");
            Console.WriteLine($"Puntos: {equipo1.Puntos}");

            Console.WriteLine($"Equipo: {equipo2.Nombre}");
            Console.WriteLine($"Partidos jugados: {equipo2.PartidosJugados}");
            Console.WriteLine($"Partidos jugados como local: {equipo2.PartidosJugadosComoLocal}");
            Console.WriteLine($"Partidos jugados como visitante: {equipo2.PartidosJugadosComoVisitante}");
            Console.WriteLine($"Goles realizados: {equipo2.GolesRealizados}");
            Console.WriteLine($"Goles recibidos: {equipo2.GolesRecibidos}");
            Console.WriteLine($"Diferencia de goles: {equipo2.DiferenciaDeGoles}");
            Console.WriteLine($"Partidos ganados: {equipo2.PartidosGanados}");
            Console.WriteLine($"Partidos empatados: {equipo2.PartidosEmpatados}");
            Console.WriteLine($"Partidos perdidos: {equipo2.PartidosPerdidos}");
            Console.WriteLine($"Puntos: {equipo2.Puntos}");


        }
    }
}