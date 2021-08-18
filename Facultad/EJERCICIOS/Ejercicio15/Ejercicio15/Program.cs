using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, total;
            char operando;

            Console.WriteLine("Ingresar primer numero: ");
            if (int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Ingresar segundo numero: ");
                if (int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Ingresar operando (+ , - , * , /): ");
                    if (char.TryParse(Console.ReadLine(), out operando))
                    {
                        Console.WriteLine("El resultado de la operacion es: "+ Calculadora.Calcular(num1, num2, operando));
                    }
                }
            }

            else Console.WriteLine("Error. Debe ingresar un numero!.");
            Console.ReadKey();
        }
    }
}
