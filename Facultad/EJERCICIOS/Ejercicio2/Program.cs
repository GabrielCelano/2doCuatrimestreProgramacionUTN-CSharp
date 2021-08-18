using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
              mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
              Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.*/

            Console.Title = "Ejercicio2";
            Console.WriteLine("Ingresar numero: ");
            bool validacion = double.TryParse(Console.ReadLine(), out double num);
            if (validacion == true && num > 0)
            {
                double cuadrado = Math.Pow(num, 2);
                double cubo = Math.Pow(num, 3);
                Console.WriteLine("El cuadrado de {0} es: {1}", num, cuadrado);
                Console.WriteLine("El cubo de {0} es: {1}", num, cubo);
                Console.ReadLine();
            }

            else
            {
                do
                {
                    Console.WriteLine("ERROR. Reingresar numero: ");
                    validacion = double.TryParse(Console.ReadLine(), out num);
                    if (validacion == true && num > 0)
                    {
                        double cuadrado = Math.Pow(num, 2);
                        double cubo = Math.Pow(num, 3);
                        Console.WriteLine("El cuadrado de {0} es: {1}", num, cuadrado);
                        Console.WriteLine("El cubo de {0} es: {1}", num, cubo);
                        Console.ReadLine();
                    }
                } while (validacion != true || num <= 0);
            }

        }
    }
}
