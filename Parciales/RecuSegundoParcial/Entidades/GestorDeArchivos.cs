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
    public class GestorDeArchivos : IGuardar<Carrera>, IGuardar<AutoF1>
    {
        private string archivo;

        public GestorDeArchivos(string archivo)
        {
            this.archivo = archivo;
        }

        public void Guardar(Carrera tipo)
        {
            string rutaFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            XmlTextWriter writer = new XmlTextWriter(Path.Combine(rutaFile, this.archivo), Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(Carrera));
            try
            {
                serializer.Serialize(writer, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar XML", ex);
            }
            finally
            {
                writer.Close();
            }
        }

        void IGuardar<AutoF1>.Guardar(AutoF1 auto)
        {
            string rutaFile;
            if (!string.IsNullOrEmpty(this.archivo) && !string.IsNullOrEmpty(auto.ToString()))
            {
                try
                {
                    rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    using (StreamWriter auxSw = new StreamWriter(Path.Combine(rutaFile, this.archivo), true))
                    {
                        auxSw.WriteLine(auto.ToString());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar TXT", ex);
                }
            }

        }
        public Carrera LeerXML()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + this.archivo);
            try
            {
                Carrera carrera = new Carrera();
                using (XmlTextReader reader = new XmlTextReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Carrera));
                    carrera = (Carrera)serializer.Deserialize(reader);
                    return carrera;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al leer XML", ex);
            }
        }
    }
}
