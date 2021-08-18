using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio51
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.UnidadesDeEscritura = unidades;
        }
        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }
        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            foreach (char item in texto)
            {
                this.UnidadesDeEscritura -= 0.3F;
            }
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} Color:  {1} Unidades de escritura: {2}", "Boligrafo", this.Color, this.UnidadesDeEscritura);

            return sb.ToString();
        }
    }
}
