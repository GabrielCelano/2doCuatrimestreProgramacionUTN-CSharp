using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadFinanciera
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public PrestamoPesos(float monto, DateTime vencimiento, float interes) : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres):this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        {

        }

        public float Interes { get { return this.CalcularInteres(); } }

        private float CalcularInteres()
        {
            return (this.porcentajeInteres * base.monto) / 100;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            float incremento = (DateTime.Now - nuevoVencimiento).Days;
            incremento = incremento * (float)0.25;

            this.porcentajeInteres += incremento;
            base.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"\nPorcentaje interes: {this.porcentajeInteres} Intereses: {this.Interes}");
            return sb.ToString();
        }
    }
}