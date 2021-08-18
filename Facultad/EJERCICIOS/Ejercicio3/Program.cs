using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";
            /*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
              Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/
            bool validacion;
            int num, i, cont = 0;
            do
            {
                Console.WriteLine("Cuantos primos desea mostrar: ");
                validacion = int.TryParse(Console.ReadLine(), out num);
            } while (validacion != true || num <= 1);

            Console.WriteLine("Numeros primos:");

            while ()
            {

                for (i = 2; i <= 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}
