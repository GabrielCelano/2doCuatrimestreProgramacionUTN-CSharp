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
            Console.Title = "Ejercicio 36";

            Competencia comp = new Competencia(50, 4, TipoCompetencia.F1);
            Competencia comp2 = new Competencia(10, 4, TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(16, "Ferrari");
            AutoF1 a2 = new AutoF1(44, "Mercedes");
            AutoF1 a3 = new AutoF1(33, "RedBull");
            AutoF1 a4 = new AutoF1(14, "Renault");

            MotoCross m1 = new MotoCross(12, "Yamaha", 100);
            MotoCross m2 = new MotoCross(19, "Ducati", 120);

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

            if (comp + m1)
            {
                Console.WriteLine("M1 agregado correctamente.");
            }
            else
            {
                Console.WriteLine("M1 no se pudo agregar.");
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

            if (comp2 + m1)
            {
                Console.WriteLine("M1 agregado correctamente.");
            }
            else
            {
                Console.WriteLine("M1 no se pudo agregar.");
            }

            if (comp2 + m2)
            {
                Console.WriteLine("M2 agregado correctamente.");
            }
            else
            {
                Console.WriteLine("M2 no se pudo agregar.");
            }

            if (comp2 + a1)
            {
                Console.WriteLine("A1 agregado correctamente.");
            }
            else
            {
                Console.WriteLine("A1 no se pudo agregar.");
            }

            Console.WriteLine(comp2.MostrarDatos());
            Console.ReadKey();
        }
    }
}
