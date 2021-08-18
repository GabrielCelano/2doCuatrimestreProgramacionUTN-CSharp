using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase obj = new OtraClase();
                obj.MetodoInstancia();
            }
            catch(MiExcepcion e)
            {
                Console.WriteLine(e.Message);
                Exception inners;
                inners = e.InnerException;
                while (inners != null)
                {
                    Console.WriteLine(inners.Message);
                    inners = inners.InnerException;
                }
            }

            Console.ReadKey();
        }
    }
}
