using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto car = new Auto("Chevrolet");
            Console.WriteLine(Auto.GetCantidadRuedas());
            Console.ReadKey();
        }
    }
}
