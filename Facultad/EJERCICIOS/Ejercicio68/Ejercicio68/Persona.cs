using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio68
{
    public delegate void DelegadoString(string msg);
    public class Persona
    {
        public event DelegadoString EventoString;

        private string apellido;
        private string nombre;

        public Persona()
        {
            
        }

        public string Apellido
        {
            get { return this.apellido; }
            set 
            { 
                this.apellido = value;
                this.EventoString(this.apellido);
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            { 
                this.nombre = value;
                this.EventoString(this.nombre);
            }
        }
        public string Mostrar()
        {
            return string.Format($"{this.Nombre}, {this.Apellido}");
        }
    }
}