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
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores { get { return cantidadCompetidores; } set { cantidadCompetidores = value; } }
        public short CantidadVueltas { get { return cantidadVueltas; } set { cantidadVueltas = value; } }
        public TipoCompetencia Tipo { get { return tipo; } set { tipo = value; } }
        public VehiculoDeCarrera this[int i] { get { return this.competidores[i]; } } //Indexador

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            Random numRandom = new Random();
            short num = (short)numRandom.Next(15, 100);
            if (c.competidores.Count < c.cantidadCompetidores && c != a && (c.competidores.Count == 0 || c[0].GetType().ToString() == a.GetType().ToString()))
            {
                c.Tipo = a.GetType().ToString() == "Ejercicio_36.AutoF1" ? TipoCompetencia.F1 : TipoCompetencia.MotoCross;
                c.competidores.Add(a);
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = num;
                return true;
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Operador +");
            }
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            return c.competidores.Contains(a);
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
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
            sb.AppendLine($"Tipo de carrera: {this.Tipo}// Cantidad competidores {this.cantidadCompetidores} // Cantidad vueltas: {this.cantidadVueltas}");

            sb.AppendLine("\nLista de competidores: ");
            foreach (VehiculoDeCarrera item in this.competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }
    }
}