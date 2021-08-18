using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio69
{
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizarNombreDelegate(string dato);

        public event ActualizarNombreDelegate EventoActualizarNombre;
        public event ActualizarNombreDelegate EventoActualizarImagen;

        private string imagePath;
        public FrmTestDelegados()
        {
            InitializeComponent();
            //Comienza en el directorio especificado
            this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            //Filtro el tipo de archivo
            this.openFileDialog.Filter = "Imágenes|*.jpg;*.gif;*.png;*.bmp|Todos|*.*";
            this.openFileDialog.FileName = "";

            //Deshabilito que pueda seleccionar varios
            this.openFileDialog.Multiselect = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!object.ReferenceEquals(this.EventoActualizarNombre, null))
            {
                this.EventoActualizarNombre.Invoke(this.txtDato.Text);
                this.EventoActualizarImagen.Invoke(this.imagePath);
            }
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.imagePath = this.openFileDialog.FileName;
            }
        }
    }
}
