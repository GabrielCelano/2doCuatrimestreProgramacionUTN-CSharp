using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    public class Sumador
    {
        #region Atributos
        private int cantidadSumas;
        #endregion

        #region Constructores
        public Sumador(int cantidad)
        {
            this.cantidadSumas = cantidad;
        }

        public Sumador()
        {

        }
        #endregion

        #region Metodos
        public long Sumar(long numero1, long numero2)
        {
            this.cantidadSumas++;
            return numero1 + numero2;
        }

        public string Sumar(string numero1, string numero2)
        {
            this.cantidadSumas++;
            return String.Format("{0} {1}", numero1, numero2);
        }
        #endregion

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas == s2.cantidadSumas);
        }
    }
}
