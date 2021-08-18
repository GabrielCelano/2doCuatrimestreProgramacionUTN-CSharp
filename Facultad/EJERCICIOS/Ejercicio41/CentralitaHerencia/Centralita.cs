using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Metodos
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            foreach (Llamada item in listaDeLlamadas)
            {
                if (item is Local)
                {
                    gananciaLocal += ((Local)item).CostoLlamada;
                }
                else if (item is Provincial)
                {
                    gananciaProvincial += ((Provincial)item).CostoLlamada;
                }
            }
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return gananciaLocal;
                case Llamada.TipoLlamada.Provincial:
                    return gananciaProvincial;
                default:
                    return gananciaProvincial + gananciaLocal;
            }
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia total: ${CalcularGanancia(Llamada.TipoLlamada.Todas)}");
            sb.AppendLine($"Ganancia local: ${CalcularGanancia(Llamada.TipoLlamada.Local)}");
            sb.AppendLine($"Ganancia provincial: ${CalcularGanancia(Llamada.TipoLlamada.Provincial)}");
            sb.AppendLine("\n\n----------------------------\n\nLista de llamadas:\n");
            foreach (Llamada item in this.listaDeLlamadas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada item in c.listaDeLlamadas)
            {
                if (item == llamada)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            
            if (c != nuevaLlamada)
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                throw new CentralitaException("ya existe/", "Llamador/", "Operador +/");
            }
            return c;
        }
        #endregion
    }
}
