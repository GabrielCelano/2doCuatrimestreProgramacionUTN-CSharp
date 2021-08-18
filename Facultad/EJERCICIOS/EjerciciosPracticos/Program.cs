using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
              valor máximo, el valor mínimo y el promedio.*/

            Console.Title = "Ejercicio Nro1";
            double[] numeros = new double[5];
            ingresarNumeros(numeros);
            calcularMin(numeros);
            calcularMax(numeros);
            calcularPromedio(numeros);
        }

        private static void ingresarNumeros(double[] numeros)
        {
            double acu = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingresar numero: ");
                numeros[i] = double.Parse(Console.ReadLine());
                acu++;
            }
        }

        private static void calcularMin(double[] numeros)
        {
            double min = numeros[0];
            foreach (double item in numeros)
            {
                if (item < min)
                    min = item;
            }
            Console.WriteLine("El valor minimo es: " + min);
        }

        private static void calcularMax(double[] numeros)
        {
            double max = numeros[0];
            foreach (double item in numeros)
            {
                if (item > max)
                    max = item;
            }
            Console.WriteLine("El valor maximo es: " + max);
        }

        private static void calcularPromedio(double[] numeros)
        {
            double promedio = 0;
            foreach (double item in numeros)
            {
                promedio += item;
            }
            Console.WriteLine("El valor maximo es: " + promedio / numeros.Length);
        }
    }
}
