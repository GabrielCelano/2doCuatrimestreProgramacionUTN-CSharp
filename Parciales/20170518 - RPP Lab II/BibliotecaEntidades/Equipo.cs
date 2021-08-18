using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Equipo
    {
        private static Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;

        public enum Deportes { Basquet, Futbol, Handball, Rugby }

        public Deportes Deporte { set { Equipo.deporte = value; } }

        static Equipo()
        {
            Equipo.deporte = Deportes.Futbol;
        }
        public Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre, DirectorTecnico dt):this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte) : this(nombre, dt)
        {
            Equipo.deporte = deporte;
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador item in e.jugadores)
            {
                if (item == j)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e==j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j)
            {
                e.jugadores.Add(j);
                return e;
            }
            return e;
        }

        public static Equipo operator -(Equipo e, Jugador j)
        {
            if (e == j)
            {
                e.jugadores.Remove(j);
                return e;
            }
            return e;
        }

        public static implicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**{e.nombre}**");
            sb.AppendLine($"{e.dt}");
            sb.AppendLine($"Nomina de jugadores: {e.jugadores.Count}");
            foreach (Jugador item in e.jugadores)
            {
                sb.AppendLine($"{item.ToString()}");
            }

            return sb.ToString();
        }
    }
}