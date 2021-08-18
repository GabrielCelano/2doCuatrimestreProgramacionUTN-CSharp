using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate string FinalDelegate(string texto);
    public delegate U SimuladoDelegate<U>(U item);
    public class SimuladorDeAtencion<T>
    {
        public event FinalDelegate FinDeUso;
        public event SimuladoDelegate<T> AvisoDeUso;

        public void SimularVacunacion(object param)
        {

            List<T> lista = (List<T>)param;
            foreach (T item in lista)
            {
                if (!object.ReferenceEquals(AvisoDeUso, null))
                {
                    AvisoDeUso.Invoke(item);
                    Thread.Sleep(1200);
                }
            }
            if (lista.Count > 0)
            {
                FinDeUso.Invoke("Tarea finalizada.");
            }
        }
    }
}
