using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            string pathArchivoEnEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo + ".txt");
            StreamWriter sW = new StreamWriter(pathArchivoEnEscritorio, true);

            try
            {
                sW.WriteLine(datos.Dequeue());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar .TXT", ex);
            }
            finally
            {
                sW.Close();
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            string pathArchivoEnEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo + ".txt");
            StreamReader sR = new StreamReader(pathArchivoEnEscritorio);

            Queue<Patente> auxQueue = new Queue<Patente>();
            Patente auxPatente = new Patente();
            string auxCodigoPatente = "";

            try
            {
                while (!sR.EndOfStream)
                {
                    auxCodigoPatente = sR.ReadLine();
                    auxPatente = auxCodigoPatente.ValidarPatente();

                    if (auxPatente != null)
                    {
                        auxQueue.Enqueue(auxPatente);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer .TXT", ex);
            }
            finally
            {
                sR.Close();
            }

            datos = auxQueue;
        }
    }
}
