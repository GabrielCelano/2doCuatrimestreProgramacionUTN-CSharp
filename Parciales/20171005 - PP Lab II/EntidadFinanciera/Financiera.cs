using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        private Financiera()
        {
            listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial):this()
        {
            this.razonSocial = razonSocial;
        }

        public float InteresesEnDolares { get { return this.CalcularInteresGanado(PrestamoDolar.TipoDePrestamo.Dolares); } }
        public float InteresesEnPesos { get { return this.CalcularInteresGanado(PrestamoDolar.TipoDePrestamo.Pesos); } }
        public float InteresesTotales { get { return this.CalcularInteresGanado(PrestamoDolar.TipoDePrestamo.Todos); } }
        public List<Prestamo> ListaDePrestamo { get { return this.listaDePrestamos; } }
        public string RazonSocial { get { return this.razonSocial; } }
        private float CalcularInteresGanado(Prestamo.TipoDePrestamo tipoPrestamo)
        {
            PrestamoDolar auxDolar;
            PrestamoPesos auxPesos;
            float acumInteres = 0;

            foreach (Prestamo item in this.listaDePrestamos)
            {
                switch (tipoPrestamo)
                {
                    case Prestamo.TipoDePrestamo.Pesos:
                        if (item is PrestamoPesos)
                        {
                            auxPesos = (PrestamoPesos)item;
                            acumInteres += auxPesos.Interes;
                        }
                        break;
                    case Prestamo.TipoDePrestamo.Dolares:
                        if (item is PrestamoDolar)
                        {
                            auxDolar = (PrestamoDolar)item;
                            acumInteres += auxDolar.Interes;
                        }
                        break;
                    case Prestamo.TipoDePrestamo.Todos:
                        if (item is PrestamoDolar)
                        {
                            auxDolar = (PrestamoDolar)item;
                            acumInteres += auxDolar.Interes;
                        }
                        else
                        {
                            auxPesos = (PrestamoPesos)item;
                            acumInteres += auxPesos.Interes;
                        }
                        break;
                }
            }

            return acumInteres;
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

        public static explicit operator string(Financiera financiera)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Razon social: {financiera.razonSocial}");
            //sb.AppendLine($"Intereses totales: {financiera.InteresesTotales}, Intereses en pesos: ${financiera.InteresesEnPesos}, Intereses en dolares: U$D{financiera.InteresesEnDolares}");
            //financiera.OrdenarPrestamos();
            //foreach (Prestamo item in financiera.listaDePrestamos)
            //{
            //    sb.AppendLine(item.Mostrar());
            //}
            //return sb.ToString();

            StringBuilder str = new StringBuilder($"Razon social: {financiera.RazonSocial}");

            str.AppendLine($"Intereses totales: {financiera.InteresesTotales} Pesos: {financiera.InteresesEnPesos} Dolares: {financiera.InteresesEnDolares}");

            financiera.OrdenarPrestamos();
            financiera.ListaDePrestamo.ForEach(k => str.AppendLine(k.Mostrar()));

            return str.ToString();

        }

        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            return financiera.listaDePrestamos.Contains(prestamo);
            //foreach (Prestamo item in financiera.listaDePrestamos)
            //{
            //    if (prestamo == item)
            //    {
            //        return true;
            //    }
            //}

            //return false;
        }

        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }

        public static Financiera operator +(Financiera financiera, Prestamo prestamo)
        {
            if (financiera != prestamo)
            {
                financiera.listaDePrestamos.Add(prestamo);
                return financiera;
            }
            return financiera;
        }

        public void OrdenarPrestamos()
        {
            this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
    }
}