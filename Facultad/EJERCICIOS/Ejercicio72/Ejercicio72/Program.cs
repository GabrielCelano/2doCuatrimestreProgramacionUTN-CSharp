using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio72
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            while (cont < 5)
            {
                Console.Write("Ingrese un numero: ");
                long num = long.Parse(Console.ReadLine());
                Console.WriteLine($"Numero de     {num.CantidadDeDigitos()} digitos");
                cont++;
            }
        }
    }
}
