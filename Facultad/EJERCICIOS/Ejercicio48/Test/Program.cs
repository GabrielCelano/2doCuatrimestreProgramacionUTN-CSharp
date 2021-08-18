using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            Recibo recibo1 = new Recibo();
            Recibo recibo2 = new Recibo(1000);
            Recibo recibo3 = new Recibo(2000);

            Factura factura1 = new Factura(3000);
            Factura factura2 = new Factura(2500);
            Factura factura3 = new Factura(1500);

            contabilidad += recibo1;
            contabilidad += recibo2;
            contabilidad += recibo3;

            contabilidad += factura1;
            contabilidad += factura2;
            contabilidad += factura3;

            Console.WriteLine(contabilidad.Mostrar());
            Console.ReadKey();
        }
    }
}
