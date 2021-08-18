using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio69
{
    public partial class FrmPrincipal : Form
    {
        FrmTestDelegados frmTestDelegados;
        FrmMostrar frmMostrar;
        FrmAltaAlumno frmAltaAlumno;
        FrmDatosAlumnos frmDatosAlumnos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tsiTestDelegados_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados = new FrmTestDelegados();

            this.frmTestDelegados.Owner = this; //Asigno un propietario

            this.frmTestDelegados.MdiParent = this; //Asigno un contenedor

            this.frmTestDelegados.Show();

            this.tsiMostrar.Enabled = true;
        }

        private void tsiMostrar_Click(object sender, EventArgs e)
        {
            this.frmMostrar = new FrmMostrar();

            this.frmMostrar.Owner = this;

            this.frmMostrar.MdiParent = this;

            this.frmMostrar.Show();

            this.frmTestDelegados.EventoActualizarNombre += this.frmMostrar.ActualizarNombre;
            this.frmTestDelegados.EventoActualizarImagen += this.frmMostrar.ActualizarFoto;
        }

        private void tsiAlumno_Click(object sender, EventArgs e)
        {
            this.frmAltaAlumno = new FrmAltaAlumno();

            this.frmAltaAlumno.Owner = this;

            this.frmAltaAlumno.MdiParent = this;

            this.frmAltaAlumno.Show();

            this.tsiDatosAlumnos.Enabled = true;
        }

        private void tsiDatosAlumnos_Click(object sender, EventArgs e)
        {
            this.frmDatosAlumnos = new FrmDatosAlumnos();

            this.frmDatosAlumnos.Owner = this;

            this.frmDatosAlumnos.MdiParent = this;

            this.frmDatosAlumnos.Show();

            this.tsiDatosAlumnos.Enabled = true;

            this.frmAltaAlumno.EventoActualizarAlumno += this.frmDatosAlumnos.ActualizarAlumno;
        }
    }
}
