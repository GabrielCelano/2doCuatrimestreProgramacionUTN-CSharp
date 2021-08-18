using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class GatoSiames : Gato
    {
        public GatoSiames(string nombre) : base(nombre)
        {

        }

        public override string EmitirSonido()
        {
            return "El sonido del gato siames.";
        }

        public override string ResumenDeDatos()
        {
            return this.nombre;
        }
    }
}
