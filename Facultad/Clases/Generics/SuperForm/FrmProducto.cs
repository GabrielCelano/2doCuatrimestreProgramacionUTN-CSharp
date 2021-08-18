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
    public partial class FrmProducto : Form
    {
        public Producto producto;
        public FrmProducto()
        {
            InitializeComponent();
            this.producto = Validadora.inicializarElemento<Producto>(producto);
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            producto.Nombre = txtNombre.Text;
            producto.Marca = txtMarca.Text;
            producto.Precio = float.Parse(txtPrecio.Text);
            producto.Codigo = txtCodigo.Text;

            if (Validadora.validarProducto(producto))
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
