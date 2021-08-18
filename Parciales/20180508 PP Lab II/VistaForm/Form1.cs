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
    public partial class Form1 : Form
    {
        Curso curso;
        private List<Alumno> listaDeAlumnos;
        public Form1()
        {
            InitializeComponent();
            cmbDivisionAlumno.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            this.listaDeAlumnos = new List<Alumno>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfesor.Text);
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            curso = new Curso((short)nudAnioCurso.Value, division, profesor);

            if (listaDeAlumnos.Count > 0)
            {
                foreach (Alumno item in listaDeAlumnos)
                {
                    curso += item;
                }
            }
            MessageBox.Show("El curso fue creado.");
            btnCrearCurso.Enabled = false;
        }

        private void btnMostrarCurso_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(curso, null))
            {
                MessageBox.Show("Aun no se a agredado un curso.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                rtbDatos.Text = (string)curso;
            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            Alumno alumno = new Alumno(txtNombreAlumno.Text, txtApellidoAlumno.Text, txtLegajoAlumno.Text, (short)nudAnio.Value, division);
            string mensaje = "";

            if (ReferenceEquals(curso, null))
            {
                listaDeAlumnos.Add(alumno);
                mensaje = ", aun no se a creado un curso.";
            }

            else
            {
                curso += alumno;
                rtbDatos.Text = (string)curso;
            }

            MessageBox.Show("El alumno a sido creado!" + mensaje);
        }
    }
}
