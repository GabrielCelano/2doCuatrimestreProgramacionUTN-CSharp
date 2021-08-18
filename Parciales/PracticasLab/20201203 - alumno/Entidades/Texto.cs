using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            string rutaFile;
            if (!string.IsNullOrEmpty(archivo) && !string.IsNullOrEmpty(datos))
            {
                try
                {
                    rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    using (StreamWriter auxSw = new StreamWriter(Path.Combine(rutaFile, archivo), true))
                    {
                        auxSw.WriteLine(datos);
                        return true;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return false;
        }

        public bool Leer(string archivo, out string datos)
        {
            string rutaFile;
            datos = "";
            if (!string.IsNullOrEmpty(archivo))
            {
                try
                {
                    rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    using (StreamReader auxSw = new StreamReader(Path.Combine(rutaFile, archivo)))
                    {
                        datos = auxSw.ReadToEnd();
                        return true;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return false;
        }
    }
}
