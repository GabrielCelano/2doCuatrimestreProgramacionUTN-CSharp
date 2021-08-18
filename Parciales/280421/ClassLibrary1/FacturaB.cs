using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FacturaB : Factura
    {
        public FacturaB(string nombreCliente, string numeroDeCuit) : base(nombreCliente, numeroDeCuit)
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

        public override string RetornarNumeroDeCuit()//esto es redundancia de codigo
        {
            // return base.RetornarNumeroDeCuit();    //ESTO ES LLAMAR A LA FUNCIONALIDAD DEL BASE--->ESTO APARECE POR DEFECTO
            return this.CuitEmisor;//conviene usar el de arriba (base)
            //return this.RetornarNumeroDeCuit;     //error, es una redundancia ciclica

            //TODO ESTE BLOQUE ES AL PEDO PORQUE YA LO HACE LA BASE
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
