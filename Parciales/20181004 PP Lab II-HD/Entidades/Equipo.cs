using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }

        public string Nombre { get { return this.nombre; } }
        public DirectorTecnico DirectorTecnico { set { if (value.ValidarAptitud()) this.directorTecnico = value; } }

        public static explicit operator string(Equipo e)
        {
            string DT;
            StringBuilder sb = new StringBuilder();
            if (ReferenceEquals(e.directorTecnico, null))
            {
                DT = "Sin DT asignado";
            }
            else
            {
                DT = e.directorTecnico.Mostrar();
            }

            sb.AppendLine(DT);
            foreach (Jugador item in e.jugadores)
            {
                sb.AppendLine(item.Mostrar());
            }

            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            return e.jugadores.Contains(j);
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < Equipo.cantidadMaximaJugadores && j.ValidarAptitud() && e != j)
            {
                e.jugadores.Add(j);
            }
            return e;
        }
        public static bool ValidarEquipo(Equipo e)
        {
            if (!ReferenceEquals(e.directorTecnico, null))
            {
                int[] acuArray = new int[4];
                foreach (Jugador item in e.jugadores)
                {
                    switch (item.Posicion)
                    {
                        case Posicion.Arquero:
                            acuArray[0]++;
                            break;
                        case Posicion.Defensor:
                            acuArray[1]++;
                            break;
                        case Posicion.Central:
                            acuArray[2]++;
                            break;
                        case Posicion.Delantero:
                            acuArray[3]++;
                            break;
                        default:
                            break;
                    }
                }

                if (e.jugadores.Count == Equipo.cantidadMaximaJugadores && acuArray[0] == 1)
                {
                    foreach (int item in acuArray)
                    {
                        if (item == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
    }
}