using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{

    #region Consigna

    /*

    a.	Clase estática y genérica que solo admitirá aquellos objetos que implementen la interfaz ISerializable y que además posean el constructor por defecto.
    
    b.	El método estático Guardar recibirá un parámetro genérico el cual se serializará con el siguiente formato de nombre 
             	XXXXX_ClienteAtendido.xml    donde XXXXX es el DNI del cliente.
       
    c.	El método estático GenerarTicket recibirá un parámetro genérico el cual escribirá un archivo de texto con las siguientes características:
                  i.	 Factura_XXXXX.txt donde XXXXX  es el DNI del parámetro
                  ii.	 Dentro del archivo, deberá generar el siguiente formato:

                                FECHA: "Fecha de hoy ( usar la clase DateTime)"

                                DATOS CLIENTE: "los datos del cliente"

                                PRECIO:  "aqui generar un valor aleatorio usando la clase random"

                                ESTADO: ABONADO
     */
    #endregion


    public static class Archivos<T> where T : ISerializable, new()
    {
        readonly static string ruta;

        static Archivos()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\FinalLab2\\";
        }

        public static void Guardar(T dato)
        {
            string archivo = string.Format($"{dato.DNI}_ClienteAtendido.xml");
            XmlTextWriter writer = new XmlTextWriter(Path.Combine(ruta, archivo), Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                serializer.Serialize(writer, dato);
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

        public static void GenerarTicket(T dato)
        {
            Random random = new Random();
            string factura = string.Format($"Factura_{dato.DNI}.txt");
            string archivo = string.Format($"Fecha: {DateTime.Now}\n" +
                            $"DATOS DEL CLIENTE: {dato.ToString()}\n" +
                            $"PRECIO: ${random.Next(500, 1000)}\n" +
                            $"ESTADO: ABONADO");
            if (!string.IsNullOrEmpty(ruta))
            {
                try
                {
                    using (StreamWriter auxSw = new StreamWriter(Path.Combine(ruta, factura), true))
                    {
                        auxSw.WriteLine(archivo);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar TXT", ex);
                }
            }
        }
    }
}
