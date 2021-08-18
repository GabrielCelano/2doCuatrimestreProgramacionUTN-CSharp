using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class SimuladorDeAtencion<T>
    {
        public event SimuladoDelegate<T> AvisoDeUso;
        public event FinalDelegate FinDeUso;

        public void SimularVacunacion(object param)
        {

            if (param is List<T>)
            {
                List<T> lista = (List<T>)param;
                foreach (T item in lista)
                {
                    if (!object.ReferenceEquals(AvisoDeUso, null))
                    {
                        this.AvisoDeUso(item);
                        Thread.Sleep(1200);
                    }
                }
                Texto<T> txt = new Texto<T>();
                txt.Guardar("PacientesAtendidos.log", lista);

                if (!object.ReferenceEquals(FinDeUso, null))
                    this.FinDeUso("Tarea finalizada");
            }

        }
    }
}
