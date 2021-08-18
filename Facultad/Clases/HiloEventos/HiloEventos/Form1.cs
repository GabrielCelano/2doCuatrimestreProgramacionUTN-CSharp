using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HiloEventos
{
    public partial class Form1 : Form
    {
        Thread descarga;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            Descargador d = new Descargador();
            //Suscribo mi evento
            d.FinDescarga += this.ImprimirDescarga;

            if (this.descarga == null || !this.descarga.IsAlive)
            {
                this.descarga = new Thread(new ParameterizedThreadStart(d.DescargarMaterial));
                this.descarga.Start("https://es.wikipedia.org/wiki/Segunda_Guerra_Mundial");
            }

            //rtbArchivo.Text = d.DescargarMaterial("https://es.wikipedia.org/wiki/Segunda_Guerra_Mundial");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.descarga != null)
            this.descarga.Abort();
        }

        //CREADO EN DESCARGADOR -> public delegate void *CallBack(string mensaje);
        //Cuando hago this.FinDescarga.Invoke(aux); llamo a este evento
        public void ImprimirDescarga(string mensaje)
        {
            //if (this.rtbArchivo.InvokeRequired)
            if (this.InvokeRequired) //Pregunto si necesito invocar al hilo principal para modificarlo/ si estoy parado en el hilo secundario hago el if, sino el else
            {
        /******/CallBack callback = new CallBack(this.ImprimirDescarga);//Mediante el delegado invoco al hilo principal
                                                                        //Le digo al delegado que ejecute el metodo ImprimirDescarga
                                                                        //Porque necesito ejecutarlo en el hilo principal
 
                object[] args = new object[] { mensaje };

                this.Invoke(callback, args);//Aca le digo al hilo principal que tiene que ejecutar el metodo callback(ImprimirDescarga), en su hilo
                                            //Entonces ejecuta este mismo metodo de nuevo, pero en el hilo principal
                                            //Al estar en el hilo principal el if va dar false
            }
            else
            {
                this.rtbArchivo.Text = mensaje;//Ya puedo escribir en mi RichTextBox
            }
        }
    }
}
