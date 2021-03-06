using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;


        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(int id, string nombre, string apellido):this(nombre, apellido)
        {
            this.id = id;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.ID} ");
            sb.Append($"{this.Nombre} ");
            sb.Append($"{this.Apellido}");
            return sb.ToString();
        }
    }
}
