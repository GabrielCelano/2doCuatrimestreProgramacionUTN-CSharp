using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
              calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
              con DateTime.Now).
              Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/

            Console.WriteLine("Ingresar fecha de nacimiento: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
            {
                DateTime Today = DateTime.Now;
                Console.WriteLine("Viviste {0} dias ", (Today - fechaNacimiento).Days);
            }
            Console.ReadKey();
        }
    }
}
