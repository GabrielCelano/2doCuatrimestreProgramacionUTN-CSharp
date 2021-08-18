using Entidades;
using General;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Views
{
    public partial class FrmVacunatorio : Form
    {
        FrmLlamador llamadador;
        private CentroDeVacunacion centroDeVacunacion;
        public FrmVacunatorio()
        {
            InitializeComponent();
            this.centroDeVacunacion = new CentroDeVacunacion();
        }


        private void btnXml_Click(object sender, EventArgs e)
        {
            XML<Paciente> xml = new XML<Paciente>();
            List<Paciente> listaAux;
            listaAux = xml.Leer("centrovacunacion");
            this.llamadador = new FrmLlamador(listaAux);
            this.llamadador.Show();

        }

        private void btnBaseDeDatos_Click(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            List<Paciente> listaAux;
            string consulta = "INSERT INTO Pacientes(turno, nombre, apellido) VALUES(@turno ,@nombre, @apellido)";
            listaAux = bd.Leer(consulta, this.centroDeVacunacion.Personas);

            this.llamadador = new FrmLlamador(listaAux);
            this.llamadador.Show();

        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
        }

        public void GuardarArchivoTexto(List<string> lista)
        {
            
        }


        private void FrmVacunatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.CerrarFormulario())
            {
                e.Cancel = true;   
            }
        }

        private bool CerrarFormulario()
        {
            DialogResult result = MessageBox.Show("Esta seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.CerrarFormulario())
            {
                this.Close();
            }
        }
    }
}
