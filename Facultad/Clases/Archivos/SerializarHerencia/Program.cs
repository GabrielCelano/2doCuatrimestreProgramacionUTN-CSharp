using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                listaAnimales.Add(new PalomaDeCiudad("Palometa", 2, "Gris"));
                listaAnimales.Add(new PatoDelCampo("Lucas", 3));

                using (XmlTextWriter xw = new XmlTextWriter("Animal.xml", Encoding.UTF8))
                {
                    XmlSerializer escritorArchivo = new XmlSerializer(typeof(List<Animal>));
                    escritorArchivo.Serialize(xw, listaAnimales);
                }
            }
            catch
            {

            }
        }
    }
}
