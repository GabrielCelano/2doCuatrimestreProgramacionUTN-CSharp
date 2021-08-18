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

namespace VistaForm
{
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;
        public FormDT()
        {
            InitializeComponent();
        }

        private void FormDT_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)nudEdad.Value, (int)nudDni.Value, (int)nudExperiencia.Value);
            MessageBox.Show("Se ha creado el DT!");
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (!ReferenceEquals(dt, null))
            {
                if (dt.ValidarAptitud())
                {
                    MessageBox.Show("El DT es apto.");
                }

                else
                {
                    MessageBox.Show("El DT no es apto.");
                }
            }

            else
            {
                MessageBox.Show("Aun no se ha creado el DT del formulario", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
