using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            Console.WriteLine("Lista de numeros generados: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-20, 20);
                if (array[i] == 0)
                {
                    i--;
                    array[i] = i;
                }
                Console.WriteLine($"Numero: {array[i]}");
            }

            Console.WriteLine();
            Array.Sort(array);

            Console.WriteLine("Lista ordenada:");
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine($"Numero: {array[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Solo positivos(Orden decreciente):");
            for (int i = array.Length-1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    Console.WriteLine($"Numero: {array[i]}");
                }
            }


            Console.WriteLine();
            Console.WriteLine("Solo negativos(Orden creciente):");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine($"Numero: {array[i]}");
                }
            }

            Console.ReadKey();
        }
    }
}
