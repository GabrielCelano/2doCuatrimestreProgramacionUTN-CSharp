using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializarHerencia
{
    public class PatoDelCampo : Animal
    {
        public PatoDelCampo()
        {

        }
        public PatoDelCampo(string nombre, float peso) : base(nombre, peso)
        {
            
        }
    }
}
