using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador a = new Sumador();
            Sumador b = new Sumador();

            Console.WriteLine("Suma: {0}, {1}", a.Sumar(40, 50), a.Sumar("Buen","dia!"));
            Console.WriteLine("Suma: {0}, {1}", b.Sumar(80, 30), b.Sumar("Tengo", "suenio!!"));

            if (a | b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
