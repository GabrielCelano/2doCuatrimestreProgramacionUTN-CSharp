using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadFinanciera
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periciocidad;

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periciocidad):base(monto, vencimiento)
        {
            this.periciocidad = periciocidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periciocidad):this(prestamo.Monto, prestamo.Vencimiento, periciocidad)
        {
            
        }

        public PeriodicidadDePagos Periodicidad { get { return this.periciocidad; } }
        public float Interes { get { return this.CalcularInteres(); } }

        private float CalcularInteres()
        {
            float aux = 0;
            switch (this.Periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    aux = (this.monto * 25) / 100;
                    break;
                case PeriodicidadDePagos.Bimestral:
                    aux = (this.monto * 35) / 100;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    aux = (this.monto * 40) / 100;
                    break;
            }
            return aux;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float incremento = (DateTime.Now - nuevoVencimiento).Days;
            incremento = incremento * (float)2.5;

            this.monto += incremento;
            base.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"\nPeriodicidad: {this.Periodicidad} Intereses: {this.Interes}");
            return sb.ToString();
        }
    }
}