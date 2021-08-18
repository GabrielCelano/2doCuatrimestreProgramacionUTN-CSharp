using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarHerencia
{
    public class PalomaDeCiudad : Animal
    {
        public string color;
        public PalomaDeCiudad()
        {

        }
        public PalomaDeCiudad(string nombre, float peso, string color) : base(nombre, peso)
        {
            this.color = color;
        }


    }
}
