using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class XML<T> : IArchivos<T>
    {
        public bool Leer(string rutaArchivo, out T objeto)
        {
            bool aux = false;
            try
            {
                using (XmlTextReader reader = new XmlTextReader(rutaArchivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    objeto = (T)serializer.Deserialize(reader);
                    aux = true;
                    return aux;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoInvalidoException("Error al levantar archivo .xml", ex.InnerException);
            }
        }
    }
}
