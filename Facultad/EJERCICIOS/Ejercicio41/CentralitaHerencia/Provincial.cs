using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string nroOrigen, Franja miFranja, float duracion, string nroDestino) : base(duracion, nroDestino, nroOrigen)
        {
           this.franjaHoraria = miFranja;
        }
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Metodos
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar()); ;
            sb.AppendLine($"Costo de la llamada provincial: ${this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");
            sb.AppendLine("");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            float aux = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    aux = base.Duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    aux = base.Duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    aux = base.Duracion * (float)0.66;
                    break;
            }
            return aux;
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
        #endregion
    }
}
