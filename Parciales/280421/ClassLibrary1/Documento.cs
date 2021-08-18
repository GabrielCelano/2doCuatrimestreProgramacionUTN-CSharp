using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Documento
    {
        private string nombreDelCliente;
        private string cuitEmisor;

        public abstract string NombreYCuit
        {
            get;
        }
        //public string NombreDelCliente { get => nombreDelCliente; set => nombreDelCliente = value; }
        //public string CuitEmisor { get => cuitEmisor; set => cuitEmisor = value; }

        public abstract string RetornarNombreYCuit();
        
    }
}
