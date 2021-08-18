using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Entidades;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo(5, 10, ConsoleColor.Red);
            Rectangulo rectangulo = new Rectangulo(10, 20, ConsoleColor.Blue);
            List<Figura> listaFiguras = new List<Figura>();

            listaFiguras.Add(triangulo);
            listaFiguras.Add(rectangulo);

            foreach (Figura item in listaFiguras)
            {
                if (item is Triangulo)
                {
                    ((Triangulo)item).MostrarDatos();
                }
                else if (item is Rectangulo)
                {
                    ((Rectangulo)item).MostrarDatos();
                }
            }


            Console.ReadKey();
        }
    }
}
