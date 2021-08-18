using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public delegate void AvisoFinCallback(string mensaje);
    public class LosHilos : IRespuesta<int>
    {
        public event AvisoFinCallback EventoAvisoFin;

        private int id;
        private List<InfoHilo> misHilos;

        public LosHilos()
        {
            this.id = 0;
            this.misHilos = new List<InfoHilo>();
        }
        public string Bitacora
        {
            get
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ruta += "\\bitacora.txt";

                if (File.Exists(ruta))
                {
                    using (StreamReader lector = new StreamReader(ruta))
                    {
                        return lector.ReadToEnd();
                    }
                }
                return " ";
            }

            set
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ruta += "\\bitacora.txt";

                using (StreamWriter escritor = new StreamWriter(ruta, true))
                {
                    escritor.WriteLine(value);
                }

            }
        }

        private static LosHilos AgregarHilo(LosHilos hilos)
        {
            hilos.id++;
            InfoHilo nuevoHilo = new InfoHilo(hilos.id, hilos);
            hilos.misHilos.Add(nuevoHilo);
            return hilos;
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (!(hilos is null))
            {
                if (cantidad < 1)
                {
                    throw new CantidadInvalidaException();
                }
                else
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        LosHilos.AgregarHilo(hilos);
                    }
                }
            }
            return hilos;
        }


        public void RespuestaHilo(int id)
        {
            string mensaje = string.Format($"Termino el hilo {id}.");
            this.Bitacora = mensaje;
            if(!object.ReferenceEquals(EventoAvisoFin, null))
            this.EventoAvisoFin.Invoke(mensaje);
        }
    }
}
