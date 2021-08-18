using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";
            /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
              (excluido el mismo) que son divisores del número.
              El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
              Escribir una aplicación que encuentre los 4 primeros números perfectos.
              Nota: Utilizar estructuras repetitivas y selectivas.*/
            int b; int num; int j;
            string divisores = "";

            Console.Write("Determine hasta que numero desea realizar la busqueda de numeros perfectos: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                b = 0;

                for (j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        b += j;
                        divisores += " " + j + " ";
                    }
                }
                if (b == i)
                    Console.WriteLine("El numero " + i + " es perfecto y su divisores son: " + divisores);
                divisores = "";
            }
            Console.ReadKey();
        }
    
    }
}
