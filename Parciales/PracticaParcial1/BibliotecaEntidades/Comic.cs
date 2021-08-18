using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Comic : Publicacion
    {
        private bool esColor;
        protected override bool EsColor { get { return this.esColor; } }

        public Comic(string nombre, bool esColor, int stock, float valor) : base(nombre, stock, valor)
        {
            this.esColor = esColor;
        }
    }
}