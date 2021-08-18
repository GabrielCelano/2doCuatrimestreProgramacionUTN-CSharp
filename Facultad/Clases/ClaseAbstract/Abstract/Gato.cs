using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {

        }

        protected override bool EsDomestico
        {
            get
            {
                return true;
            }
        }
        public override string EmitirSonido()
        {
            return "Miauuu";
        }

        public override string ResumenDeDatos()
        {
            return this.nombre;
        }
    }
}
