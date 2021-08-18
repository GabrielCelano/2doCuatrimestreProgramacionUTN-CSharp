using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";

            int alturaTorre = 5;
            Console.WriteLine("Ingresar altura de la torre: ");
            if (int.TryParse(Console.ReadLine(), out alturaTorre))
            {
                Console.WriteLine();
                for (int i = 1; i <= (alturaTorre*2); i=i+2)
                {
                    Console.WriteLine();
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
