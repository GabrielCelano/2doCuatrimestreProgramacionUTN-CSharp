using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Paciente
    {
        private string apellido;
        private string nombre;
        private int turno;
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
        public int Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }
        public Paciente() { }
        public Paciente(string apellido, string nombre, int turno)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Turno = turno;
        }

        public override string ToString()
        {
            return string.Format($"{this.Apellido}, {this.Nombre}");
        }
    }
}
