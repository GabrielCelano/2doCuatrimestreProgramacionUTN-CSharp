using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public sealed class Remito : Documento
    {
        public override string NombreYCuit
        {
            get
            {
                return this.NombreYCuit;
            }

        }

        public override string RetornarNombreYCuit()
        {
            return this.NombreYCuit;
        }
    }
}
