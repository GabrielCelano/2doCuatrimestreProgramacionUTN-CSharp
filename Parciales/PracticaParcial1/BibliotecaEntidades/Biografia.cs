using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Biografia : Publicacion
    {
        protected override bool EsColor { get { return false; } }
        public override bool HayStock
        {
            get
            {
                if (Stock > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Biografia(string nombre) : base(nombre)
        {

        }

        public Biografia(string nombre, int stock) : base(nombre, stock)
        {

        }

        public Biografia(string nombre, int stock, float valor) : base(nombre, stock, valor)
        {

        }

        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
}