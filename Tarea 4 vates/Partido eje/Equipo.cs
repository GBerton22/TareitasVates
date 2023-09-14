namespace PARTIDO
{
   public class Equipo
{
    public string Nombre { get; set; }

    public int PartidosJugados { get; private set; }
    public int PartidosJugadosComoLocal { get; private set; }
    public int PartidosJugadosComoVisitante { get; private set; }

    public int GolesRecibidos { get; private set; }
    public int GolesRealizados { get;  set; }
    public int DiferenciaDeGoles { get; private set; }


    public int PartidosGanados { get;  set; }
    public int PartidosEmpatados { get;  set; }
    public int PartidosPerdidos { get;  set; }
    
    public int Puntos { get; private set; }

    public void RegistrarPartido(Partido partido)
    {
        PartidosJugados++;
        if (partido.EquipoLocal == this)
        {
            PartidosJugadosComoLocal++;
        }
        else
        {
            PartidosJugadosComoVisitante++;
        }
        GolesRecibidos += partido.GolesVisitante;
        GolesRealizados += partido.GolesLocal;
        DiferenciaDeGoles = GolesRealizados - GolesRecibidos;
        if (partido.GolesLocal > partido.GolesVisitante)
        {
            PartidosGanados++;
            Puntos += 3;
        }
        else if (partido.GolesLocal == partido.GolesVisitante)
        {
            PartidosEmpatados++;
            Puntos++;
        }
        else
        {
            PartidosPerdidos++;
        }
    }
}

}