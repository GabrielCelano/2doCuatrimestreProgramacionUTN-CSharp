using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73
{
    public static class MiExtension
    {
        public static int CantidadDeSignos(this string dato)
        {
            string[] aux = dato.Split('.', ',', ';');
            //Console.WriteLine(aux.ToString());
            return aux.Length-1;
        }
    }
}
