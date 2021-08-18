using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo azul = new Boligrafo(ConsoleColor.Blue, (short)100);
            Boligrafo rojo = new Boligrafo(ConsoleColor.Red, (short)50);
            string blue;
            string red;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("1ra Pintada AZUL:");
            if (azul.Pintar((short)55, out blue))
            {
                Console.BackgroundColor = azul.GetColor();
                Console.WriteLine(blue);
            }
            else
            {
                azul.Recargar();
                Console.WriteLine("Tinta recargada");
                azul.Pintar((short)55, out blue);
                Console.BackgroundColor = azul.GetColor();
                Console.WriteLine(blue);
            }

            Console.WriteLine();

            Console.WriteLine("2da Pintada AZUL:");
            if (azul.Pintar((short)55, out blue))
            {
                Console.BackgroundColor = azul.GetColor();
                Console.WriteLine(blue);
            }
            else
            {
                azul.Recargar();
                Console.WriteLine("Tinta recargada");
                azul.Pintar((short)55, out blue);
                Console.BackgroundColor = azul.GetColor();
                Console.WriteLine(blue);
            }

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("1ra Pintada ROJA:");
            if (rojo.Pintar((short)45, out red))
            {
                Console.BackgroundColor = rojo.GetColor();
                Console.WriteLine(red);
            }
            else
            {
                rojo.Recargar();
                Console.WriteLine("Tinta recargada");
                rojo.Pintar((short)55, out red);
                Console.BackgroundColor = rojo.GetColor();
                Console.WriteLine(red);
            }

            Console.WriteLine();

            Console.WriteLine("2da Pintada ROJA:");
            if (rojo.Pintar((short)60, out red))
            {
                Console.BackgroundColor = rojo.GetColor();
                Console.WriteLine(red);
            }
            else
            {
                rojo.Recargar();
                Console.WriteLine("Tinta recargada");
                rojo.Pintar((short)55, out red);
                Console.BackgroundColor = rojo.GetColor();
                Console.WriteLine(red);
            }
        }
    }
}
