using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int aux;
            int acu = 0;
            bool val = false;

            do
            {
                do
                {
                    Console.WriteLine("Ingresar numero a sumar: ");
                    val = int.TryParse(Console.ReadLine(), out aux);
                } while (val != true);

                acu += aux;

                do
                {
                    Console.WriteLine("Continuar S/N");
                    val = char.TryParse(Console.ReadLine(), out c);
                } while (val != true);

            } while (ValidarRespuesta.validarRespuesta(c) == true);

            Console.WriteLine("La suma de todos los numeros es: " + acu);
            Console.ReadKey();
        }
    }
}
