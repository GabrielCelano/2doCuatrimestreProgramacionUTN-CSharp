using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public sealed class FacturaA_Baja : FacturaA
    {
        public FacturaA_Baja(string nombreCliente, string numeroDeCuit) : base(nombreCliente, numeroDeCuit)
        {

        }

        public override DateTime DameFechaFactura()
        {
            return base.DameFechaFactura();
        }
    }
}
