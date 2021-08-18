using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            Moto.valorHora = 30;
        }
        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada, ruedas)
        {
            Moto.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($" {this.ruedas} ruedas, {this.cilindrada}cc, ${Moto.valorHora}/hora");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            double hora = (DateTime.Now - base.ingreso).Hours;
            hora *= Moto.valorHora;
            return String.Format($"{base.ImprimirTicket()} Costo: ${hora}");
        }
        public override bool Equals(object obj)
        {
            bool equals = false;

            if (obj is Moto)
            {
                equals = ((Moto)obj).Patente == this.Patente;
            }
            return equals;
        }
    }
}