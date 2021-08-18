using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            string pathArchivoEnElEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo + ".xml");
            XmlTextWriter writer = new XmlTextWriter(pathArchivoEnElEscritorio, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                serializer.Serialize(writer, datos);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar XML", ex);
            }
            finally
            {
                writer.Close();
            }
        }

        public void Leer(string archivo, out T datos)
        {
            string pathArchivoEnElEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo + ".xml");
    
            try
            {
                using (XmlTextReader reader = new XmlTextReader(pathArchivoEnElEscritorio))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    datos = (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                datos = default;
                throw new Exception("Error al leer XML", ex);
            }
        }
    }
}
