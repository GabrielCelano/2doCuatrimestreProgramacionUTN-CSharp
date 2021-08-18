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
    public class PalomaDeCiudad : Animal
    {
        public string color;

        public PalomaDeCiudad(string color, string nombre, float pesoEnKg):base(nombre,pesoEnKg)
        {
            this.color = color;
        }

        public PalomaDeCiudad()
        { }
    }
}
