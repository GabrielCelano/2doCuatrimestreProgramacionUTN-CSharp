using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FacturaA : Factura
    {
        protected float importeSinIva;

        public FacturaA(string nombreCliente, string numeroDeCuit):base(nombreCliente, numeroDeCuit)
        {
            this.NombreDelCliente = nombreCliente;
            this.CuitEmisor = numeroDeCuit;
        }

        public float ImporteSinIva
        {
            get
            {
                return this.importeSinIva;
            }
            set
            {
                this.importeSinIva = value;
            }
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
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Factura A: "+base.RetornarNumeroDeCuit());
            return Convert.ToString(sb);
        }

        public virtual DateTime DameFechaFactura()
        {
            return DateTime.Now;
        }

        public override string RetornarNombreYCuit()
        {
            return this.NombreYCuit;
        }

        public override string NombreYCuit
        {
            get;
        }
    }
}
