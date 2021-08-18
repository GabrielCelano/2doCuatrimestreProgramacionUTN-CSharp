using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    public class Ordenar
    {
        public static int OrdenarNumeros(int a, int b)
        {
            if (a > b)
            {
                return -1;
            }
            else if (a < b)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
