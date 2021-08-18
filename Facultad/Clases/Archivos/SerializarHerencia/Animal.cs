using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializarHerencia
{
    [XmlInclude(typeof(PatoDelCampo))] 
    [XmlInclude(typeof(PalomaDeCiudad))]
    public abstract class Animal
    {
        public string nombre;
        public float pesoEnKg;
        public Animal(string nombre, float peso)
        {
            this.nombre = nombre;
            this.pesoEnKg = peso;
        }
        public Animal()
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Peso: {this.pesoEnKg}");
            return sb.ToString();
        }
    }
}
