using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        private string apellido;
        private string nombre;
        private int turno;

        #region Propiedades
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
         
        public int Turno
        {
            get
            {
                return this.turno;
            }
            set
            {
                this.turno = value;
            }
        }
        #endregion

        public Paciente() { }
        public Paciente(int turno, string nombre, string apellido)
        {
            this.Turno = turno;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public override string ToString()
        {
            return string.Format($"{this.Apellido}, {this.Nombre}");
        }
    }
}
