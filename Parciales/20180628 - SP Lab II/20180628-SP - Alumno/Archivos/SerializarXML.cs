using Excepxiones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo + ".xml");
            XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                serializer.Serialize(writer, objeto);
                return true;
            }
            catch (ErrorArchivoException ex)
            {
                return false;
                throw new ErrorArchivoException("Error al guardar XML", ex);
            }
            finally
            {
                writer.Close();
            }
        }

        public T Leer(string rutaArchivo)
        {
            T datos;
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo + ".xml");
            try
            {
                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    datos = (T)serializer.Deserialize(reader);
                    return datos;
                }
            }
            catch(ErrorArchivoException ex)
            {
                datos = (T)default;
                throw new ErrorArchivoException("Error al leer XML", ex);
            }
        }
    }
}
