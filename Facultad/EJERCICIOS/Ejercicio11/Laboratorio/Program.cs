using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Laboratorio
{
    class Program
    {
        const int MaxIngreso = 10;
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int acu = 0, aux;
            bool valIngreso = false, valRango = false;


            for (int i = 1; i <= MaxIngreso; i++)
            {
                do
                {
                    Console.WriteLine("Ingresar numero {0} (entre el -100 y 100): ", i);
                    valIngreso = int.TryParse(Console.ReadLine(), out aux);
                    valRango = Validacion.Validar(aux, -100, 100);
                } while (valIngreso != true || valRango != true);

                {
                    if (aux > max)
                    {
                        max = aux;
                    }
                    else
                    {
                        if (aux < min)
                        {
                            min = aux;
                        }
                    }
                    acu += aux;
                }
            }
            Console.Write("\nNum max : {0} \nNum Min : {1} \nPromedio : {2}", max, min, acu / MaxIngreso);
            Console.ReadKey();
        }
    }
}
