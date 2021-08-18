using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance();
    public delegate void InformacionLlegada(string mensaje);
    public class Carrera
    {
        public event InformacionDeAvance InformarAvance;
        public event InformacionLlegada InformarLlegada;

        private List<AutoF1> autos;
        private int kms;

        public Carrera()
        {
            this.autos = new List<AutoF1>();
        }
        public Carrera(int kms) : this()
        {
            this.Kms = kms;
        }

        public List<AutoF1> Autos
        {
            get { return this.autos; }
            set { this.autos = value; }
        }

        public int Kms
        {
            get { return this.kms; }
            set { this.kms = value; }
        }

        public static Carrera operator +(Carrera carrera, AutoF1 auto)
        {
            carrera.Autos.Add(auto);
            return carrera;
        }

        public void IniciarCarrera()
        {
            int cont = 1;

            GestorBaseDeDatos<AutoF1> bd = new GestorBaseDeDatos<AutoF1>();
            GestorDeArchivos gestorArchivosTexto = new GestorDeArchivos("Llegadas.log");
            IGuardar<AutoF1> texto = gestorArchivosTexto;

            while (true)
            {
                foreach (AutoF1 item in this.Autos)
                {
                    if (item.Posicion == 0)
                    {
                        item.Acelerar();


                        if (!object.ReferenceEquals(InformarAvance, null))
                            this.InformarAvance.Invoke();
                        Thread.Sleep(10);


                        if (item.UbicacionEnPista > this.Kms)
                        {
                            item.Posicion = cont++;

                            bd.Guardar(item);

                            texto.Guardar(item);


                            if (!object.ReferenceEquals(InformarLlegada, null))
                                this.InformarLlegada.Invoke(item.ToString());

                            if (cont == 2)
                                break;
                        }
                    }
                }
            }
        }
    }
}
