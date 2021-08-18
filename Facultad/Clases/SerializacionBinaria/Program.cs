using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;


namespace SerializacionBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_name = AppDomain.CurrentDomain.BaseDirectory + "SerializacionBinaria.bin";

            List<Dato> lista = new List<Dato>();

            Dato dato = new Dato("Juan", 15, 222222);
            Dato dato2 = new Dato("Gabriel", 20, 111111);

            lista.Add(dato);
            lista.Add(dato2);

            BinaryFormatter ser = new BinaryFormatter();//Similar al XmlSerializer

            FileStream fs = new FileStream(file_name, FileMode.Create);//Creo el archivo. El segundo parametro indica que hago con el archivo.
            try
            {
                ser.Serialize(fs, lista);//serializo en el archivo
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
            }
            finally
            {
                fs.Close();
            }

            List<Dato> lista2 = new List<Dato>();

            BinaryFormatter des = new BinaryFormatter();//Similar al XmlSerializer

            FileStream fs1 = new FileStream(file_name, FileMode.Open);//Creo el archivo. El segundo parametro indica que hago con el archivo.
            try
            {
                lista2 = (List<Dato>)des.Deserialize(fs1);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
            }
            finally
            {
                fs.Close();
            }

            foreach (Dato item in lista2)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
