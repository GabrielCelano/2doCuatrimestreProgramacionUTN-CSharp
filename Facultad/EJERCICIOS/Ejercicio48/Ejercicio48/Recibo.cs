using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Recibo : Documento
    {
        public Recibo(int numero) : base(numero) { }

        public Recibo() : base(0) { }
    }
}