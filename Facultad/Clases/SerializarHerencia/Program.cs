using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SerializarHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Animal> listaAnimales = new List<Animal>();
                listaAnimales.Add(new PalomaDeCiudad("Blanca", "Juan", 2));
                listaAnimales.Add(new PatoDelCampo("Carlos", 3));


                using (XmlTextWriter textw = new XmlTextWriter("animal.xml",Encoding.UTF8))
                {
                    XmlSerializer escritorArchivo = new XmlSerializer(typeof(List<Animal>));
                    escritorArchivo.Serialize(textw, listaAnimales);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
           


        }
    }
}
