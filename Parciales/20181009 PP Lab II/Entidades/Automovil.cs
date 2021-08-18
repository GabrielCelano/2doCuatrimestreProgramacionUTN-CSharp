using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            Automovil.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente,color)
        {
            Automovil.valorHora = valorHora;
        }
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($" Color: {this.color} ${Automovil.valorHora}/hora");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            double hora = (DateTime.Now - base.ingreso).Hours;
            hora *= Automovil.valorHora;
            return String.Format($"{base.ImprimirTicket()}Costo: ${hora}");
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj is Automovil)
            {
                equals = ((Automovil)obj).Patente == this.Patente;
            }
            return equals;
        }
    }
}