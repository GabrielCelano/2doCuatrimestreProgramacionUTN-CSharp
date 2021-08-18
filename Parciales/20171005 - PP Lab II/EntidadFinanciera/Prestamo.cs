using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadFinanciera
{
    public abstract class Prestamo
    {
        public enum PeriodicidadDePagos { Mensual, Bimestral, Trimestral }
        public enum TipoDePrestamo { Pesos, Dolares, Todos }

        protected float monto;
        protected DateTime vencimiento;

        protected Prestamo(float monto, DateTime vencimiento)
        {
            this.vencimiento = vencimiento;
            this.monto = monto;
        }

        public float Monto { get; }
        public DateTime Vencimiento
        {
            get { return this.vencimiento; }

            set
            {
                if (value > DateTime.Now)
                {
                    this.vencimiento = value;
                }
                else
                {
                    this.vencimiento = DateTime.Now;
                }
            }
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            return p1.Vencimiento.CompareTo(p2.Vencimiento);
        }

        public virtual string Mostrar()
        {
            return ($"\nMonto: ${this.monto} Vencimiento: {this.Vencimiento.}");
        }
        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

    }
}