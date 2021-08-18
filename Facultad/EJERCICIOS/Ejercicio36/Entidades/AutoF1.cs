using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero, escuderia) { }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza { set { this.caballosDeFuerza = value; } get { return this.caballosDeFuerza; } }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.CaballosDeFuerza == a2.CaballosDeFuerza;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.CaballosDeFuerza}HP");
            return sb.ToString();
        }
    }
}