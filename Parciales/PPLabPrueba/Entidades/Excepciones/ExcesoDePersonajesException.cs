using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcesoDePersonajesException : Exception
    {
        public ExcesoDePersonajesException(string mensaje) : base(mensaje) { }
    }
}
