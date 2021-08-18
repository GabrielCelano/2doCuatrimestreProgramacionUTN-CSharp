 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio68
{
    public partial class Form1 : Form
    {
        private Persona persona;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(this.persona, null))
            {
                this.btnCrear.Text = "Actualizar";
                this.persona = new Persona();
                this.persona.EventoString += NotificarCambio;
            }

            if (this.txtNombre.Text.CompareTo(this.persona.Nombre) != 0)
            {
                this.persona.Nombre = this.txtNombre.Text;
            }
            if (this.txtApellido.Text.CompareTo(this.persona.Apellido) != 0)
            {
                this.persona.Apellido = this.txtApellido.Text;
            }

            MessageBox.Show(this.persona.Mostrar());
        }
        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio + "NotificarCambio");
        }
    }
}
