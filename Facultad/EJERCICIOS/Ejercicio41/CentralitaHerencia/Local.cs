using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        #region Atributos
        protected float costo;
        #endregion

        #region Constructores
        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) :base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
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
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada local: ${this.CostoLlamada}");
            sb.AppendLine("");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }
        #endregion
    }
}
