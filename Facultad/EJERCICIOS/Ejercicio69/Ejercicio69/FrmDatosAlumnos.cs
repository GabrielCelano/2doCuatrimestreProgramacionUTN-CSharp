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

namespace Ejercicio69
{
    public partial class FrmDatosAlumnos : FrmAltaAlumno
    {
        public FrmDatosAlumnos()
        {
            InitializeComponent();
        }

        public void ActualizarAlumno(Alumno alumno)
        {
            base.txtNombre.Text = alumno.Nombre;
            base.txtApellido.Text = alumno.Apellido;
            base.txtDni.Text = alumno.DNI.ToString();
            this.picture.ImageLocation = alumno.FotoAlumno;
            base.txtFoto.Text = alumno.FotoAlumno;
        }
    }
}
