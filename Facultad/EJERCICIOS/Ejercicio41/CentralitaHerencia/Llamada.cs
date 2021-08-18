using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Propiedades
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public abstract float CostoLlamada { get; }
        #endregion

        #region Metodos
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion < llamada2.duracion)
            {
                return -1;
            }
            else if (llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
                return 0;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nueva llamada:");
            sb.AppendLine($"Duracion de la llamada: {this.Duracion}");
            sb.AppendLine($"Numero origen: {this.NroOrigen}");
            sb.AppendLine($"Numero destino: {this.NroDestino}");
            sb.AppendLine("");
            sb.AppendLine("Facturacion:");
            return sb.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if(l1.Equals(l2) && l1.nroOrigen == l2.nroOrigen && l1.nroDestino == l2.nroDestino)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion
    }
}
