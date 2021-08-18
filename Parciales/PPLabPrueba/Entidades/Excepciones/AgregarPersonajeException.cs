using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AgregarPersonajeException : Exception
    {
        public AgregarPersonajeException(string mensaje, Exception innert): base(mensaje, innert)
        {

        }
    }
}
