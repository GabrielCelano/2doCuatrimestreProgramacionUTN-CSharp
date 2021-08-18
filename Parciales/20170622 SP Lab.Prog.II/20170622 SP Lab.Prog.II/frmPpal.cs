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
using Interfaces;

namespace _20170622_SP_Lab.Prog.II
{
    public partial class frmPpal : Form
    {
        private LosHilos hilos;
        public frmPpal()
        {
            InitializeComponent();
            this.hilos = new LosHilos();
            this.hilos.EventoAvisoFin += MostrarMensajeFin;
        }

        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                this.hilos += 1;
            }
            catch (CantidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.hilos.Bitacora);
        }
    }
}
