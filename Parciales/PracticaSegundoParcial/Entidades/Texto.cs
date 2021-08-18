using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Texto<T> 
    {
        public bool Guardar(string archivo, List<T> lista)
        {
            bool aux = false;
            foreach (T item in lista)
            {
                string rutaFile;
                if (!string.IsNullOrEmpty(archivo) && !string.IsNullOrEmpty(item.ToString()))
                {
                    try
                    {
                        rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        using (StreamWriter auxSw = new StreamWriter(Path.Combine(rutaFile, archivo), true))
                        {
                            auxSw.WriteLine(item.ToString());
                            aux = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al guardar TXT", ex);
                    }
                }
            }
            return aux;
        }
    }
}
