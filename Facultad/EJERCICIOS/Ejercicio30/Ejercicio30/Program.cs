using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 30";

            Competencia comp = new Competencia(50, 3);
            AutoF1 a1 = new AutoF1(16, "Ferrari");
            AutoF1 a2 = new AutoF1(44, "Mercedes");
            AutoF1 a3 = new AutoF1(33, "RedBull");
            AutoF1 a4 = new AutoF1(14, "Renault");

            //Console.WriteLine(a1.MostrarDatos());

            if (comp + a1)
            {
                Console.WriteLine("A1 agregado correctamente.");
            }
            else
            {
                Console.WriteLine("A1 no se pudo agregar.");
            }

            if (comp + a2)
            {
                Console.WriteLine("A2 agregado correctamente.");
            }
            else
            {
                Console.WriteLine("A2 no se pudo agregar.");
            }

            if (comp + a3)
            {
                Console.WriteLine("A3 agregado correctamente.");
            }
            else
            {
                Console.WriteLine("A3 no se pudo agregar.");
            }

            if (comp + a4)
            {
                Console.WriteLine("A4 agregado correctamente.");
            }
            else
            {
                Console.WriteLine("A4 no se pudo agregar.");
            }      

            Console.WriteLine(comp.MostrarDatos());

            if (comp - a3)
            {
                Console.WriteLine("A3 se retiro correctamente.");
            }
            else
            {
                Console.WriteLine("A3 no se pudo retirar.");
            }

            if (comp + a4)
            {
                Console.WriteLine("A4 agregado correctamente.");
            }
            else
            {
                Console.WriteLine("A4 no se pudo agregar.");
            }

            Console.WriteLine(comp.MostrarDatos());

            Console.ReadKey();
        }
    }
}
