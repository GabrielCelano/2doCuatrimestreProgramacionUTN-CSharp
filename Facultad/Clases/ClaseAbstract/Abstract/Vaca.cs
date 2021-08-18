using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Vaca : Animal
    {
        protected int cantidadDeComidaAlDia;
        public Vaca(string nombre, int cantidad) : base(nombre)
        {
            this.cantidadDeComidaAlDia = cantidad;
        }

        protected override bool EsDomestico 
        {
            get
            {
                return false;
            }
        }

        public override string EmitirSonido()
        {
            return "Muuuu";
        }

        public string Comer()
        {
            return "Estoy comiendo";
        }

        public override string ResumenDeDatos()
        {
            return "Soy una vaca de la clase vaca";
        }

        public new string NoVirtual()
        {
            return "Metodo no virtual de la clase vaca.";
        }
    }
}
