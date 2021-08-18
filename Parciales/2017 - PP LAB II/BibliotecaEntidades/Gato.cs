using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }
        protected override string Ficha()
        {
            return String.Format($"Nombre: {this.Nombre}, Raza: {this.Raza}");
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            return (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza);
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Gato)
            {
                return this == (Gato)obj;
            }
            return false;
        }
    }
}