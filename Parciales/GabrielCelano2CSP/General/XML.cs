using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace General
{
    public class XML<T> : IAchivos<T>
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
            catch (ArchivoInvalidoException ex)
            {
                return false;
                throw new ArchivoInvalidoException("Error en XML", ex);
            }
            finally
            {
                writer.Close();
            }
        }

        public List<T> Leer(string rutaArchivo)
        {
            T datos;
            List<T> lista = new List<T>();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo + ".xml");
            try
            {
                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    datos = (T)serializer.Deserialize(reader);
                    lista.Add(datos);
                    return lista;
                }
            }
            catch (ArchivoInvalidoException ex)
            {
                datos = (T)default;
                throw new ArchivoInvalidoException("Error en XML", ex);
            }
        }

        public List<T> Leer(string archivo, List<T> lista)
        {
            throw new NotImplementedException();
        }
    }
}
