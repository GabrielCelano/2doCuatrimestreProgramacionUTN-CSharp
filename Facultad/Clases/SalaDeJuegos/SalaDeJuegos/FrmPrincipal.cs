using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaDeJuegos
{
    public partial class FrmPrincipal : Form
    {
        public string nombre;
        public FrmPrincipal()
        {
            this.InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Esta seguro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAdivinaNumero_Click(object sender, EventArgs e)
        {
            bool inicio = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item is FrmAdivinaNumero)
                {
                    inicio = true;
                }
            }
            if (!inicio)
            {
                FrmAdivinaNumero frmAdivinaNumero = new FrmAdivinaNumero();
                frmAdivinaNumero.MdiParent = this;
                frmAdivinaNumero.Show();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
