using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace SerializXml
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "UnPerro.xml";
                //Perro unPerro = new Perro("Pepe Reposo", "RUF RUF");
                List<Perro> listaPerros = new List<Perro>();
                listaPerros.Add(new Perro("Pepe Reposo", "RUF RUF"));
                listaPerros.Add(new Perro("Carola Reposa", "Rottweiler"));
                listaPerros.Add(new Perro("Jazmin rufosa", "Pitbull"));
                listaPerros.Add(new Perro("Ayudante de Santa", "Huesudo"));



                //escribir
                using (XmlTextWriter auxArchivo = new XmlTextWriter(rutaArchivo, Encoding.UTF8))//Creo el archivo que va a ser escrito
                {
                    XmlSerializer auxEscritor = new XmlSerializer(typeof(List<Perro>));//Creo quien va a escribir el archivo y de que tipo
                                                                                 //será lo que se escriba

                    auxEscritor.Serialize(auxArchivo, listaPerros);//Hago que el escritor escriba (serialice) al perro en ese archivo
                }



                List<Perro> listaVacia = new List<Perro>();
                //leer datos
                if (File.Exists(rutaArchivo))
                {
                    using (XmlTextReader auxArchivoALeer = new XmlTextReader(rutaArchivo))
                    {
                        XmlSerializer auxLector = new XmlSerializer(typeof(List<Perro>));
                        listaVacia = (List<Perro>)auxLector.Deserialize(auxArchivoALeer);
                    }
                }




            }
            catch (Exception)
            {
                throw;
            }



        }
    }
}
