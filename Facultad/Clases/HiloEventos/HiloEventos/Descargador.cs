using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HiloEventos
{
    public delegate void CallBack(string mensaje);
    internal class Descargador
    {
        public event CallBack FinDescarga;
        public void DescargarMaterial(object url)
        {
            string aux = this.DescargarMaterial((string)url);//Toco el boton descargar y empieza aca

            //this.FinDescarga?.Invoke(aux);
            if (!object.ReferenceEquals(this.FinDescarga, null))//Pregunta si el evento contiene un metodo o es null
                this.FinDescarga.Invoke(aux);
        }

        public string DescargarMaterial(string url)
        {
            string aux;
            try
            {
                using (WebClient client = new WebClient())//Inicia la descarga
                {
                    aux = client.DownloadString(url);
                }
            }
            catch (Exception e)
            {
                aux = e.Message;
            }
            return aux;
        }
    }
}
