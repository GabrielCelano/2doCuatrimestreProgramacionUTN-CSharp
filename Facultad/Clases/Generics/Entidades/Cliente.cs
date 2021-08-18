using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        protected string nombre;
        protected string apellido;
        protected string dni;

        public Cliente()
        {
            this.nombre = null;
            this.apellido = null;
            this.dni = null;
        }

        public Cliente(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
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

        public string Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Cliente: {0}, {1}\n", this.apellido, this.nombre);
            sb.AppendFormat("Dni: {0}\n", this.dni);
            sb.AppendLine("");
            sb.AppendLine("-------------------------------------");
            return sb.ToString();
        }
    }
}
