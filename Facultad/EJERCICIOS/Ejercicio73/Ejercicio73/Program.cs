using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73
{
    class Program
    {
        static void Main(string[] args)
        {
            string datos;

            Console.WriteLine("Ingresar texto: ");
            datos = Console.ReadLine();
            Console.WriteLine($"Cantidad de signos: {datos.CantidadDeSignos()}");
        }
    }
}
