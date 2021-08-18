using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public int Edad { set { this.edad = value; } get { return this.edad; } }
        public bool EsAlfa { set { this.esAlfa = value; } get { return this.esAlfa; } }

        protected override string Ficha()
        {
            if (this.EsAlfa)
            {
                return String.Format($"Nombre: {this.Nombre} {this.Raza}, alfa de la manada, edad: {this.Edad}");
            }
            else
            {
                return String.Format($"Nombre: {this.Nombre} Raza: {this.Raza}, edad: {this.Edad}");
            }
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            return (j1.Nombre == j2.Nombre && j1.Edad == j2.Edad && j1.Raza == j2.Raza);
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public static explicit operator int(Perro perro)
        {
            return (int)perro.Edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            if (obj is Perro)
            {
                return this == (Perro)obj;
            }
            return false;
        }
    }
}