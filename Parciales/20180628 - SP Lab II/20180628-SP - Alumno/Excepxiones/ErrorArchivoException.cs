using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepxiones
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException(string mensaje) : base(mensaje) { }
        public ErrorArchivoException(string mensaje, Exception innerException) : base(mensaje, innerException) { }
    }
}
