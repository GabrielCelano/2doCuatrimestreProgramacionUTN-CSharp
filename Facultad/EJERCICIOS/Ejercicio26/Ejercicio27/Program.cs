using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            Queue<int> colaPositivos = new Queue<int>();
            Stack<int> pilaPositivos = new Stack<int>();
            Queue<int> colaNegativos = new Queue<int>();
            Stack<int> pilaNegativos = new Stack<int>();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                listaNumeros.Add(random.Next(-50, 50));
            }

            Console.WriteLine("Lista completa de numeros ingresados: ");
            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }

            listaNumeros.Sort(Ordenar.OrdenarNumeros);
            Console.WriteLine("\nLista ordenada: ");
            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nLista solo numeros positivos(orden decreciente): ");
            foreach (int item in listaNumeros)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
                else if (item < 0)
                {
                    colaNegativos.Enqueue(item);
                    pilaNegativos.Push(item);
                }
            }

            Console.WriteLine("\nLista solo numeros negativos(orden creciente): ");
            for (int i = listaNumeros.Count - 1; i >= 0; i--)
            {
                if (listaNumeros[i] < 0)
                {
                    Console.WriteLine(listaNumeros[i]);
                }
                else if (listaNumeros[i] > 0)
                {
                    colaPositivos.Enqueue(listaNumeros[i]);
                    pilaPositivos.Push(listaNumeros[i]);
                }
            }

            Console.WriteLine("\nCola positivos: ");
            foreach (int item in colaPositivos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nPila positivos: ");
            foreach (int item in pilaPositivos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCola negativos: ");
            foreach (int item in colaNegativos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nPila negativos: ");
            foreach (int item in pilaNegativos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
