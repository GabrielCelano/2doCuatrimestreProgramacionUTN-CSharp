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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public List<Producto> listaProductos;
        public List<Cliente> listaClientes;
        public StringBuilder sbProductos;
        public StringBuilder sbClientes;


        private void FrmSuper_Load(object sender, EventArgs e)
        {
            this.listaProductos = new List<Producto>();
            this.listaClientes = new List<Cliente>();
            this.sbProductos = new StringBuilder();
            this.sbClientes = new StringBuilder();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = Validadora.inicializarProducto(null);

            FrmProducto formProducto = new FrmProducto();
            formProducto.ShowDialog();
            if (Validadora.validarProducto(formProducto.producto))
            {
                listaProductos.Add(formProducto.producto);
                sbProductos.AppendLine(formProducto.producto.ToString());
                rtbProductos.Text = sbProductos.ToString();
            }

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = Validadora.inicializarCliente(null);

            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
            if (Validadora.validarCliente(frmCliente.cliente))
            {
                listaClientes.Add(frmCliente.cliente);
                sbClientes.AppendLine(frmCliente.cliente.ToString());
                rtbClientes.Text = sbClientes.ToString();
            }


        }

        private void rtbProductos_TextChanged(object sender, EventArgs e)
        {
            rtbProductos.Text = sbProductos.ToString();
        }

        private void rtbClientes_TextChanged(object sender, EventArgs e)
        {
            rtbClientes.Text = sbClientes.ToString();
        }


    }
}
