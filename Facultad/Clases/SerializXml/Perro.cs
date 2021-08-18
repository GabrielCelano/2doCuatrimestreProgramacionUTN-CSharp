using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializXml
{
    [Serializable]
    public class Perro
    {
        string nombre;
        string raza;

       
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

        public string Raza
        {
            get
            {
                return this.raza;
            }
            set
            {
                this.nombre = value;
            }
        }

        public Perro(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public Perro ()
        {

        }

        public override string ToString()
        {
            return "Nombre: " + nombre + " - Raza: " + raza ;
        }
    }
}
