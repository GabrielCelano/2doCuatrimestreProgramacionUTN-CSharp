using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public static class ArchivoTexto
    {
        public static bool Guardar(string archivo, string datos)
        {
            if (!string.IsNullOrEmpty(archivo) && !string.IsNullOrEmpty(datos))
            {
                string rutaFile = AppDomain.CurrentDomain.BaseDirectory + "LogErrores.txt";

                using (StreamWriter auxSw = new StreamWriter(rutaFile, true))
                {
                    auxSw.WriteLine(datos);
                    return true;
                }
            }
            return false;
        }

        public static bool Leer(string archivo, out string datos)
        {
            datos = "";
            try
            {
                if (!string.IsNullOrEmpty(archivo))
                {
                    string rutaFile = AppDomain.CurrentDomain.BaseDirectory + "LogErrores.txt";

                    using (StreamReader auxSr = new StreamReader(rutaFile))
                    {
                        datos = auxSr.ReadToEnd();
                        return true;
                    }
                }
            }
            catch
            {
                throw new FileNotFoundException();
            }
            return false;
        }
    }
}
