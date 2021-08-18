using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string apellido;
        private int dni;
        private string fotoAlumno;
        private string nombre;

        public Alumno(string apellido, int dni, string fotoAlumno, string nombre)
        {
            this.Apellido = apellido;
            this.DNI = dni;
            this.FotoAlumno = fotoAlumno;
            this.Nombre = nombre;
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string FotoAlumno
        {
            get { return this.fotoAlumno; }
            set { this.fotoAlumno = value; }
        }

        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

    }
}
