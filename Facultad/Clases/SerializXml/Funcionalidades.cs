using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace SerializXml
{
    public static class Funcionalidades <T> where T: IMostrarDatos
    {
        public static void GuiardarEnTxt(List<T> auxLista, string nombre)
        {
            string nombreArchivo = AppDomain.CurrentDomain.BaseDirectory + nombre;

            using (StreamWriter auxSw = new StreamWriter(nombreArchivo))
            {
                foreach (var item in auxLista)
                {
                    auxSw.WriteLine(item.MostrarDatosCompletos());
                }
            }
            Console.WriteLine("Archivo escrito correctamente");
        }
    }
}
