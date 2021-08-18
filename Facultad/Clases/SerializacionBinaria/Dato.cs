using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionBinaria
{
    [Serializable]
    public class Dato
    {
        public string nombre;
        public int numero;
        public int numeraso;

        public Dato() { }
        public Dato(string nombre, int numero, int numeraso)
        {
            this.nombre = nombre;
            this.numero = numero;
            this.numeraso = numeraso;
        }

        public override string ToString()
        {
            return string.Format($"{this.nombre},  {this.numero}, {this.numeraso}");
        }
    }
}
