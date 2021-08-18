using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class Texto : IAchivos<string>
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

        public List<string> Leer(string archivo, List<string> lista)
        {
            throw new NotImplementedException();
        }
    }
}
