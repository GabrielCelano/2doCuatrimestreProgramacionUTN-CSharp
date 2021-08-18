using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Auto
    {
        private static int cantidadRuedas;
        private string marca;
        private string modelo;

        static Auto()
        {
            Auto.cantidadRuedas = 4;
        }

        public Auto(string marca)
        {
            this.marca = marca;
            this.modelo = string.Format("{0} - {1} ruedas", this.marca, Auto.cantidadRuedas);
        }

        public static int GetCantidadRuedas()
        {
            return Auto.cantidadRuedas;
        }

        public static void SetCantidadRuedas(int cantidad)
        {
            Auto.cantidadRuedas = cantidad;
        }

        

    }
}
