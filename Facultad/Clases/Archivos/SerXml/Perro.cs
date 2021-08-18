using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerXml
{
    public class Perro
    {
        private string nombre;
        private string raza;

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Raza { get { return this.raza; } set { this.raza = value; } }

        public Perro()
        {

        }
        public Perro(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + " - Raza: " + this.Raza;
        }
    }
}
