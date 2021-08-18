using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio51
{

    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }
        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get { return this.tamanioMina; }
            set { this.tamanioMina = value; }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            foreach (char item in texto)
            {
                ((IAcciones)this).UnidadesDeEscritura -= (float)0.1;
            }
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0} Color: {1} Unidad de escritura: {2}", "Lapiz", ((IAcciones)this).Color, ((IAcciones)this).UnidadesDeEscritura);

            return sb.ToString();
        }
    }
}