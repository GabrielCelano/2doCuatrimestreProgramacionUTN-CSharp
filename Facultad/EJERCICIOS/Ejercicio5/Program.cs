using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
              dos grupos de números, cuyas sumas son iguales.
              El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
              cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
              49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
              Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
              usuario ingrese por consola.
              Nota: Utilizar estructuras repetitivas y selectivas.*/

            Console.Title = "Ej - 5 ";
            int numIng = 0;
            int aux = 1;



            Console.WriteLine("Ing numero para calcular centros numericos");
            if (int.TryParse(Console.ReadLine(), out numIng))
            {
                do
                {
                    int suma1 = 0;
                    int suma2 = 0;
                    int j = aux + 1;

                    for (int i = 1; i < aux; i++)
                    {
                        suma1 += i;
                    }
                    Console.WriteLine("suma1 {0} ", suma1);

                    do
                    {
                        suma2 += j;
                        j++;

                    } while (suma1 > suma2);
                    Console.WriteLine("suma2 {0} ", suma2);

                    if (suma1 == suma2)
                    {
                        Console.WriteLine("Centro num {0}, suma {1} ", aux, suma1);
                    }
                    aux++;
                } while (aux < numIng);
            }
            Console.ReadKey();
        }
    }
}
