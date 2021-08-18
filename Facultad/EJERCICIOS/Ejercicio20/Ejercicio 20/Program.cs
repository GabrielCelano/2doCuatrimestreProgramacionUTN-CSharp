using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";

            Euro euro = new Euro(1);
            Dolar dolar = new Dolar(1);
            Pesos peso = new Pesos(1);

            Console.WriteLine("Get cantidad: Euro: € {0} Dolar: U$S {1} Peso: $ {2}", euro.GetCantidad(), dolar.GetCantidad(), peso.GetCantidad());
            Console.WriteLine("\nGet cotizacion: \nEuro: € {0} \nDolar:  U$S {1} \nPeso: ${2}", Euro.GetCotizacion(), Dolar.GetCotizacion(), Pesos.GetCotizacion());

            Console.WriteLine("\nConversiones:");
            Console.WriteLine("\nDe peso a dolar: U$S {0}", ((Dolar)peso).GetCantidad());
            Console.WriteLine("De peso a euro: € {0}", ((Euro)peso).GetCantidad());

            Console.WriteLine("\nDe dolar a peso: $ {0}", ((Pesos)dolar).GetCantidad());
            Console.WriteLine("De dolar a euro: € {0}", ((Euro)dolar).GetCantidad());

            Console.WriteLine("\nDe euro a peso: $ {0}", ((Pesos)euro).GetCantidad());
            Console.WriteLine("De euro a dolar: U$S {0}", ((Dolar)euro).GetCantidad());

            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("Sumas y restas:\n");
            Dolar auxD = dolar + euro;
            Console.WriteLine("Dolar + Euro: " + auxD.GetCantidad());
            auxD = dolar + peso;
            Console.WriteLine("Dolar + Peso: " + auxD.GetCantidad());

            Pesos auxP = peso + euro;
            Console.WriteLine("Peso + Euro: " + auxP.GetCantidad());
            auxP = peso + dolar;
            Console.WriteLine("Peso + Dolar: " + auxP.GetCantidad());

            Euro auxE = euro + peso;
            Console.WriteLine("Euro + Peso: " + auxE.GetCantidad());
            auxE = euro + dolar;
            Console.WriteLine("Euro + Dolar: " + auxE.GetCantidad());

            Console.WriteLine("----------------------------------------------");




            Console.ReadKey();
        }
    }
}
