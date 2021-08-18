using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            byte nota1;
            byte nota2;
            int legajo;
            string seguir = "n";

            List<Alumno> alumnos = new List<Alumno>();

            do
            {
                Console.WriteLine("Ingresar nombre del alumno: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingresar apellido del alumno: ");
                apellido = Console.ReadLine();

                Console.WriteLine("Ingresar legajo del alumno(1000-9999): ");
                while (!int.TryParse(Console.ReadLine(), out legajo))
                {
                    Console.WriteLine("Error al ingresar legajo del alumno(1000-9999): ");
                    int.TryParse(Console.ReadLine(), out legajo);
                }
                alumnos.Add(new Alumno(nombre, apellido, legajo));

                //Console.WriteLine("Ingresar nota del primer parcial: ");
                //while (!byte.TryParse(Console.ReadLine(), out nota1))
                //{
                //    Console.WriteLine("Error al ingresar primer nota(ingresar numeros): ");
                //    byte.TryParse(Console.ReadLine(), out nota1);
                //}

                //Console.WriteLine("Ingresar nota del segundo parcial: ");
                //while (!byte.TryParse(Console.ReadLine(), out nota1))
                //{
                //    Console.WriteLine("Error al ingresar segunda nota(ingresar numeros): ");
                //    byte.TryParse(Console.ReadLine(), out nota2);

                //}


                Console.WriteLine("Quiere seguir ingresando alumnos? (s/n):");
                seguir = Console.ReadLine();

            } while (seguir == "s");

            foreach (Alumno item in alumnos)
            {
                item.Estudiar((byte)10, (byte)10);
                //item.Estudiar((byte)4, (byte)4);
                //item.Estudiar((byte)1, (byte)1);
                item.CalcularFinal();
                Console.WriteLine(item.MostrarAlumno());
            }
        }
    }
}
