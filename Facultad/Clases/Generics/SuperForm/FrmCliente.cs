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

namespace SuperForm
{
    public partial class FrmCliente : Form
    {
        public Cliente cliente;
        public FrmCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = Validadora.inicializarElemento<Cliente>(cliente);
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Dni = txtDni.Text;

            if(Validadora.validarCliente(cliente))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete correctamente todos los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
