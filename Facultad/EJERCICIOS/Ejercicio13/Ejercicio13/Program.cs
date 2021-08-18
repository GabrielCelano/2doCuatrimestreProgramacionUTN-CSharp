using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            string bin;

            Console.WriteLine("Ingresar numero entero: ");
            if (double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Num({0}) convertido a binario: {1}", num, Conversor.DecimalBinario(num));
            }

            Console.WriteLine("Ingresar numero binario: ");
            bin = Console.ReadLine();
            Console.WriteLine("Num({0}) convertido a decimal: {1}", bin, Conversor.BinarioDecimal(bin));
            Console.ReadKey();
        }
    }
}
