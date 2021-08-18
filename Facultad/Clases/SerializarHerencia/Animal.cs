using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SerializarHerencia
{
    [Serializable]
    [XmlInclude(typeof(PatoDelCampo))]
    [XmlInclude(typeof(PalomaDeCiudad))]
    public abstract class Animal
    {
        public string nombre;
        public float pesoEnKg;

        public Animal(string nombre, float pesoEnKg)
        {
            this.nombre = nombre;
            this.pesoEnKg = pesoEnKg;
        }

        public Animal()
        { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Peso: {this.pesoEnKg}");
            return sb.ToString();
        }
    }
}
