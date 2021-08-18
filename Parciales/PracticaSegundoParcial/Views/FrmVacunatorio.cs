using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Views
{
    public partial class FrmVacunatorio : Form
    {
        private CentroDeVacunacion centro;
        public FrmVacunatorio()
        {
            InitializeComponent();
            //this.centro = new CentroDeVacunacion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                string path;
                opdBuscadorArchivos = new OpenFileDialog();
                if (opdBuscadorArchivos.ShowDialog() == DialogResult.OK)
                {
                    path = opdBuscadorArchivos.FileName;
                    XML<CentroDeVacunacion> xml = new XML<CentroDeVacunacion>();
                    if (xml.Leer(path, out this.centro))
                    {
                        FrmLlamador frmLlamador = new FrmLlamador(this.centro.Pacientes);
                        frmLlamador.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n" + ex.InnerException, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            try
            {
                BD<CentroDeVacunacion> bd = new BD<CentroDeVacunacion>();
                if (bd.Leer("SELECT turno, nombre, apellido FROM Pacientes", out this.centro))
                {
                    FrmLlamador frmLlamador = new FrmLlamador(this.centro.Pacientes);
                    frmLlamador.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n" + ex.InnerException, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            try
            {
                string path;
                opdBuscadorArchivos = new OpenFileDialog();
                if (opdBuscadorArchivos.ShowDialog() == DialogResult.OK)
                {
                    path = opdBuscadorArchivos.FileName;
                    Bin<CentroDeVacunacion> bin = new Bin<CentroDeVacunacion>();
                    if (bin.Leer(path, out this.centro))
                    {
                        FrmLlamador frmLlamador = new FrmLlamador(this.centro.Pacientes);
                        frmLlamador.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n" + ex.InnerException, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmVacunatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro? Si/No", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void FrmVacunatorio_Load(object sender, EventArgs e)
        {

        }
    }
}
