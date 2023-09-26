using CollecionesPersona;

namespace CollecionesPersona
{
    using System.Collections.Generic;

    public class ComparadorNombre : IEqualityComparer<Persona>
    {
        public bool Equals(Persona x, Persona y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else
                return x.Nombre == y.Nombre;
        }

        public int GetHashCode(Persona obj)
        {
            if (obj == null)
                return 0;
            else
                return obj.Nombre.GetHashCode();
        }
    }

    public class ComparadorApellido : IEqualityComparer<Persona>
    {
        public bool Equals(Persona x, Persona y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else
                return x.Apellido == y.Apellido;
        }

        public int GetHashCode(Persona obj)
        {
            if (obj == null)
                return 0;
            else
                return obj.Apellido.GetHashCode();
        }
    }
}