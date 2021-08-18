using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, altura, basee, diametro;
            Console.WriteLine("Ingresar lado del cuadradoo: ");
            if (double.TryParse(Console.ReadLine(), out lado))
            {
                Console.WriteLine("El area del circulo es: {0} m*2",CalculoDeArea.CalcularCuadrado(lado));
            }

            Console.WriteLine("Ingresar base del triangulo: ");
            if (double.TryParse(Console.ReadLine(), out basee))
            {
                Console.WriteLine("Ingresar altura del triangulo: ");
                if (double.TryParse(Console.ReadLine(), out altura))
                {
                    Console.WriteLine("El area del triangulo es: {0} m*2",CalculoDeArea.CalcularTriangulo(basee, altura));
                }
            }

            Console.WriteLine("Ingresar diametro del ciruclo: ");
            if (double.TryParse(Console.ReadLine(), out diametro))
            {
                Console.WriteLine("El area del circulo es: {0} m*2",CalculoDeArea.CalcularCirculo(diametro));
            }

        }
    }
}
