using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ejercicio69
{
    public partial class FrmAltaAlumno : Form
    {
        public delegate void ActualizarAlumnoDelegate(Alumno alumno);
        public event ActualizarAlumnoDelegate EventoActualizarAlumno;
        public FrmAltaAlumno()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int resultado;
            if (int.TryParse(this.txtDni.Text, out resultado))
            {
                Alumno alumno = new Alumno(this.txtApellido.Text, resultado, this.txtFoto.Text, this.txtNombre.Text);
                this.EventoActualizarAlumno(alumno);
            }
            else
            {
                MessageBox.Show("El DNI debe ser numérico.");
            }
        }
        private void lblFoto_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                //Filtro el tipo de archivo
                this.openFileDialog.Filter = "Imágenes|*.jpg;*.gif;*.png;*.bmp|Todos|*.*";
                this.openFileDialog.FileName = "";

                //Deshabilito que pueda seleccionar varios
                this.openFileDialog.Multiselect = false;
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtFoto.Text = this.openFileDialog.FileName;
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
