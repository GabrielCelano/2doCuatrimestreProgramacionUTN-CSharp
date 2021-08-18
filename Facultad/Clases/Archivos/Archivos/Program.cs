using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaFile;

            try
            {

                rutaFile = AppDomain.CurrentDomain.BaseDirectory + "ArchivoTexto.txt";
                //rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ArchivoEjemplo.txt";

                using (StreamWriter auxSw = new StreamWriter(rutaFile, false))
                {
                    auxSw.WriteLine("Hola mundo");
                    auxSw.WriteLine();
                    auxSw.WriteLine("asdfasdfasdf");
                    auxSw.WriteLine("Chau mundo");
                    //auxSw.Close(); //No hace falta por el using
                }

                Console.WriteLine("Arhivo escrito.");
                Console.WriteLine("Presiones una tecla para leer el contenido.");
                Console.ReadKey();
                Console.Clear();



                rutaFile = AppDomain.CurrentDomain.BaseDirectory + "ArchivoTexto2.txt";

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
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                }
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                throw;
            }


        }
    }
}
