using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random numRandom = new Random();
            short num = (short)numRandom.Next(15, 100);
            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                a.EnCompetencia = true;
                a.CantidadCombustible = num;
                a.VueltasRestantes = c.cantidadVueltas;
                c.competidores.Add(a);
                return true;
            }
            return false;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return c.competidores.Contains(a);
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad competidores {this.cantidadCompetidores} // Cantidad vueltas: {this.cantidadVueltas}");

            sb.AppendLine("\nLista de competidores: ");
            foreach (AutoF1 item in this.competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }
    }
}