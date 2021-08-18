using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public Vehiculo (string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }
        public string Patente { get { return this.patente; } set { if (value.Length == 6) this.patente = value; } }

        public abstract string ConsultarDatos();
        public override string ToString()
        {
            return String.Format("Patente {0}", this.Patente);
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder(this.ToString());
            sb.AppendLine($" Ingreso: {this.ingreso}");
            return sb.ToString();
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}