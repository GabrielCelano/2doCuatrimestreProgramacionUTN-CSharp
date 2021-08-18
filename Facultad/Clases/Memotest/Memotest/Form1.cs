using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memotest
{
    public delegate void ImagenSeleccionada(string imagen);
    public partial class Form1 : Form
    {
        ImagenSeleccionada miDelegado;
        public Form1()
        {
            InitializeComponent();
            this.btnUno.Click += new EventHandler(button1_Click);
        }

        private int i;

        private void button1_Click(object sender, EventArgs e)
        {
            //i++;
            ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;
            ((Button)sender).BackgroundImage = Properties.Resources.Luna;
            string imagen = "Luna";
            miDelegado.Invoke(imagen);
            ((Button)sender).Text = "";
            ((Button)sender).Click -= new EventHandler(button1_Click);
            ((Button)sender).Click += new EventHandler(volverABoton);
        }

        private void volverABoton(object sender, EventArgs e)
        {
            // i++;
            ((Button)sender).BackgroundImage = null;
            ((Button)sender).Text = " ";
            string imagen = " ";
            miDelegado.Invoke(imagen);
            ((Button)sender).Click += new EventHandler(button1_Click);
            ((Button)sender).Click -= new EventHandler(volverABoton);

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            miDelegado += new ImagenSeleccionada(frm2.MostrarImagen);
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == " ")
            {
                ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;
                ((Button)sender).BackgroundImage = Properties.Resources.Luna;
                ((Button)sender).Text = "";
            }
            else
            {
                ((Button)sender).BackgroundImage = null;
                ((Button)sender).Text = " ";
            }
        }
        */
    }
}
