using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            PickUp.valorHora = 70;
        }
        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($" Modelo: {this.modelo} ${PickUp.valorHora}/hora");
            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            double hora = (DateTime.Now - base.ingreso).Hours;
            hora *= PickUp.valorHora;
            return String.Format($"{base.ImprimirTicket()} Costo: ${hora}");
        }

        public override bool Equals(object obj)
        {
            bool equals = false;

            if (obj is PickUp)
            {
                equals = ((PickUp)obj).Patente == this.Patente;
            }
            return equals;
        }
    }
}