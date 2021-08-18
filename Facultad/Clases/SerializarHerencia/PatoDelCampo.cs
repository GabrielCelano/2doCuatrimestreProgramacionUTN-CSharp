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
    public class PatoDelCampo : Animal
    {
        public PatoDelCampo(string nombre, float pesoEnKg) : base(nombre, pesoEnKg)
        {
        }

        public PatoDelCampo()
        { }
    }
}
