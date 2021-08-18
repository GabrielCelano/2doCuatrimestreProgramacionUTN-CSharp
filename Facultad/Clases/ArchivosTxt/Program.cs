using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArchivosTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaFile;


            try
            {
                 rutaFile = AppDomain.CurrentDomain.BaseDirectory + "ArchivoEjemplo.txt";
                //rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ArchivoEjemplo.txt";

                using (StreamWriter auxSw = new StreamWriter(rutaFile,false))
                {
                    auxSw.WriteLine("Hola Mundo") ;
                    auxSw.WriteLine("Soy Nahuel Perez Novoa");
                    auxSw.WriteLine("Aprendiendo Archivos");
                    auxSw.WriteLine("Fin del comunicado");

                }
                Console.WriteLine("Archivo escrito");
                Console.WriteLine("Presione una tecla para leer el contenido");
                Console.ReadKey();
                Console.Clear();

                if (File.Exists(rutaFile))
                {
                    using (StreamReader auxSr = new StreamReader(rutaFile))
                    {
                        string lineaLeida = string.Empty;

                        while ((lineaLeida = auxSr.ReadLine()) != null)
                        {
                            Console.WriteLine(lineaLeida);
                        }
                        Console.WriteLine("Archivo leido en su totalidad");
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No existe el archivo"); 
                }

            }
            catch (Exception)
            {

            }

        }
    }
}
