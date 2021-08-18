using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class ValidarRespuesta
    {
        public static bool validarRespuesta(char c)
        {
            if (c == 's' || c == 'S')
            {
                return true;
            }
            else return false;
        }
    }
}
