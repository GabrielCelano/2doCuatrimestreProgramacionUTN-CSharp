using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace SerXml
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "UnPerro.xml";
                List<Perro> listaPerros = new List<Perro>();
                listaPerros.Add(new Perro("Pepe Peposo", "RUF RUF"));
                listaPerros.Add(new Perro("Paco", "Labrador"));
                listaPerros.Add(new Perro("Tala", "Pitbull"));
                listaPerros.Add(new Perro("Marle", "Beagle"));

                //escribir datos
                using (XmlTextWriter auxArchivo = new XmlTextWriter(rutaArchivo, Encoding.UTF8))
                {
                    XmlSerializer auxSerializador = new XmlSerializer(typeof(List<Perro>));
                    auxSerializador.Serialize(auxArchivo, listaPerros);
                }

                List<Perro> listaVacia = new List<Perro>();
                //leer datos
                using (XmlTextReader auxArchivoLeer = new XmlTextReader(rutaArchivo))
                {
                    XmlSerializer auxLector = new XmlSerializer(typeof(List<Perro>));
                    listaVacia = (List<Perro>)auxLector.Deserialize(auxArchivoLeer);
                }

            }
            catch (Exception e)
            {

            }
        }
    }
}
