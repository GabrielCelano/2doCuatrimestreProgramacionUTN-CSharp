using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia): base(numero, escuderia) { }
        public MotoCross(short numero, string escuderia, short cilindrada):this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public short Cilindrada { set { this.cilindrada = value; } get { return this.cilindrada; } }
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.cilindrada == a2.cilindrada;
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.Cilindrada}cc");
            return sb.ToString();
        }
    }
}