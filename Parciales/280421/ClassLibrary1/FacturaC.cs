using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FacturaC : Factura
    {
        public FacturaC() : base ("Natalia Natalia","0")
        {

        }
        
        public FacturaC(string nombreCliente, string numeroDeCuit) : base(nombreCliente, numeroDeCuit)
        {
            this.NombreDelCliente = nombreCliente;
            this.CuitEmisor = numeroDeCuit;
        }

        public override int NumerodeFactura
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public override string RetornarDatosCompletos()
        {
            throw new NotImplementedException();
        }

        public override string RetornarNumeroDeCuit()
        {
            return "Factura C. Cuit: " + this.CuitEmisor;
        }

        public override string NombreYCuit
        {
            get;
        }

        public override string RetornarNombreYCuit()
        {
            return this.NombreYCuit;
        }
    }
}
