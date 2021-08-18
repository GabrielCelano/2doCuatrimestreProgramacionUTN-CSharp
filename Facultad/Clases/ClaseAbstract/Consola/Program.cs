using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Vaca vaca = new Vaca("Vaca1", 100);
            Animal vaca2;//Esto se puede hacer
            vaca2 = new Vaca("Vaca2", 200);//Aca guardo un a variable de una clase abstracta(clase base)

            Animal gato1 = new Gato("Arya");
            Gato gato2 = new GatoSiames("Suka");//Pasa lo mismo, porque quien resuelve la invocacion es la instancia en tiempo de ejecucion
            List<Animal> listaDeAnimales = new List<Animal>();

            listaDeAnimales.Add(gato1);
            listaDeAnimales.Add(gato2);
            listaDeAnimales.Add(vaca);
            listaDeAnimales.Add(vaca2);

            //Console.WriteLine("Lista de nombres:");
            //foreach (Animal item in listaDeAnimales)
            //{
            //    Console.WriteLine(item.ResumenDeDatos());
            //}

            //Console.WriteLine(gato1.EmitirSonido());
            //Console.WriteLine(gato2.EmitirSonido());
            Console.WriteLine(vaca.ResumenDeDatos());
            Console.WriteLine(vaca2.ResumenDeDatos());
            Console.WriteLine(vaca.NoVirtual());
            Console.WriteLine(vaca2.NoVirtual());

            Console.ReadKey();
        }
    }
}
