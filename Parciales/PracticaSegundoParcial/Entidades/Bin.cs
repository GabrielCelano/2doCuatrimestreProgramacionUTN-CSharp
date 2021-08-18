using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bin<T> : IArchivos<T> where T:CentroDeVacunacion
    {
        public bool Leer(string rutaArchivo, out T objeto)
        {
            bool aux = false;
            FileStream fs = new FileStream(rutaArchivo, FileMode.Open);
            BinaryFormatter des = new BinaryFormatter();
            try
            {
                objeto = (T)des.Deserialize(fs);
                aux = true;
                //centro.Pacientes.Add(paciente);
                //return aux;
            }
            catch (Exception ex)
            {
                throw new ArchivoInvalidoException("Error al levantar archivo .bin", ex.InnerException);
            }
            finally
            {
                fs.Close();
            }
            return aux;
        }
    }
}
