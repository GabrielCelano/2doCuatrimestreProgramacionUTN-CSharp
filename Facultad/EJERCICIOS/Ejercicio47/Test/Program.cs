using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio47;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneo1 = new Torneo<EquipoFutbol>("Copa Libertadores");
            Torneo<EquipoBasquet> torneo2 = new Torneo<EquipoBasquet>("NBA");

            EquipoFutbol equipof1 = new EquipoFutbol("Boca Juniors", DateTime.Now);
            EquipoFutbol equipof2 = new EquipoFutbol("River Plate", DateTime.Now);
            EquipoFutbol equipof3 = new EquipoFutbol("Independiente", DateTime.Now);

            EquipoBasquet equipob1 = new EquipoBasquet("Warriors", DateTime.Now);
            EquipoBasquet equipob2 = new EquipoBasquet("Lakers", DateTime.Now);
            EquipoBasquet equipob3 = new EquipoBasquet("Nets", DateTime.Now);

            torneo1 = torneo1 + equipof1;
            torneo1 = torneo1 + equipof2;
            torneo1 = torneo1 + equipof3;

            torneo2 = torneo2 + equipob1;
            torneo2 = torneo2 + equipob2;
            torneo2 = torneo2 + equipob3;

            Console.WriteLine(torneo1.Mostrar());
            Console.WriteLine(torneo2.Mostrar());

            Console.WriteLine("Partidos de futbol disputados:");
            Console.WriteLine(torneo1.JugarPartido());
            Console.WriteLine(torneo1.JugarPartido());
            Console.WriteLine(torneo1.JugarPartido());

            Console.WriteLine();

            Console.WriteLine("Partidos de basquet disputados:");
            Console.WriteLine(torneo2.JugarPartido());
            Console.WriteLine(torneo2.JugarPartido());
            Console.WriteLine(torneo2.JugarPartido());
        }
    }
}
