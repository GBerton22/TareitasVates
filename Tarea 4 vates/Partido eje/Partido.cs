namespace PARTIDO
{
    public class Partido
{
    public Equipo EquipoLocal { get; set; }
    public Equipo EquipoVisitante { get; set; }
    public int GolesLocal { get; set; }
    public int GolesVisitante { get; set; }

    public Equipo Ganador
    {
        get
        {
            if (GolesLocal > GolesVisitante)
            {
                return EquipoLocal;
            }
            else if (GolesLocal < GolesVisitante)
            {
                return EquipoVisitante;
            }
            else
            {
                return null; // Empate
            }
        }
    }

    public bool EsEmpate
    {
        get
        {
            return GolesLocal == GolesVisitante;
        }
    }
}

}