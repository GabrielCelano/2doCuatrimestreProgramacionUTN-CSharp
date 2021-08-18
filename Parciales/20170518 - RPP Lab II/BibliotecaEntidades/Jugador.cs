using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;

        public bool EsCapitan { get { return this.esCapitan; } set { this.esCapitan = value; } }
        public int Numero { get { return this.numero; } set { this.numero = value; } }

        public Jugador(string nombre, string apellido) : base(nombre, apellido)
        {
            this.esCapitan = false;
            this.numero = 0;
        }

        public Jugador(string nombre, string apellido, int numero, bool capitan) : this(nombre, apellido)
        {
            this.numero = numero;
            this.esCapitan = capitan;
        }

        protected override string FichaTecnica()
        {
            if (EsCapitan == true)
            {
                return String.Format($"{this.Nombre} {this.Apellido}, capitan del equipo, camiseta numero {this.Numero}");
            }
            else
            {
                return String.Format($"{this.Nombre} {this.Apellido}, camiseta numero {this.Numero}");
            }
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.Nombre == j2.Nombre && j1.Numero == j2.Numero && j1.Apellido == j2.Apellido);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1==j2);
        }

        public static explicit operator int(Jugador jugador)
        {
            return (int)jugador.Numero;
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }

        public override bool Equals(object obj)
        {
            if (obj is Jugador)
            {
                return true;
            }
            return false;
        }
    }
}