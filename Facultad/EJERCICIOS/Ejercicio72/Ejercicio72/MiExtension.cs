using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio72
{
    public static class MiExtension
    {
        public static int CantidadDeDigitos(this long dato)
        {
            string aux = dato.ToString();           
            return aux.Length;
        }
    }
}
