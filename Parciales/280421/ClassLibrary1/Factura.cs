using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Factura : Documento
    {
        protected float importeFinal;
        protected int numeroDeFactura;

        public string NombreDelCliente
        {
            get
            {
                return this.NombreDelCliente;
            }
            set
            {
                this.NombreDelCliente = value;
            }
        }
        public float ImporteFinal
        {
            get
            {
                return this.importeFinal;
            }
            set
            {
                this.importeFinal = value;
            }
        }

        public string CuitEmisor
        {
            get
            {
                return this.CuitEmisor;
            }
            set
            {
                this.CuitEmisor = value;
            }
        }

        public abstract int NumerodeFactura
        {
            get;
            set;
        }

        public string RetornarDatosCliente()
        {
            return this.NombreDelCliente;
        }

        public abstract string RetornarDatosCompletos();

        public Factura(string nombreCliente, string numeroDeCuit)
        {
            this.NombreDelCliente = nombreCliente;
            this.CuitEmisor = numeroDeCuit;
        }

        public virtual string RetornarNumeroDeCuit()//LOS METODOS VIRTUALES SE PUEDEN SOBREESCRIBIR
        {
            return this.CuitEmisor;
        }

    }
}
