using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLibro
{
    /// <summary>
    /// Representación en objetos de una hoja.
    /// </summary>
    public class Hoja
    {
        private List<Renglon> renglones;
        private int numero;

        public Hoja()
        {
            renglones = new List<Renglon>();
        }


        public Hoja(int numero) : this()
        {
            this.numero = numero;
            if (numero == 2 || numero == 6)
            {
                for (int nroRenglon = 0; nroRenglon < 100; nroRenglon++)
                {
                    this.renglones.Add(new Renglon());
                }
            }
            else
            {
                for (int nroRenglon = 0; nroRenglon < 90; nroRenglon++)
                {
                    this.renglones.Add(new Renglon());
                }
            }
        }


        public int Numero
        {
            get
            {
                return this.numero;
            }

            set
            {
                this.numero = value;
            }


        }

        public List<Renglon> Renglones
        {
            get
            {
                return this.renglones;
            }
            set
            {
                this.renglones = value;
            }
        }
    }
}
