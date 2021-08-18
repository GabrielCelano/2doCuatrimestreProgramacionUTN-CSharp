using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
        }

        public string Apellido { get { return this.apellido; } }
        public int Dni { get { return this.dni; } }
        public int Edad { get { return this.edad; } }
        public string Nombre { get { return this.nombre; } }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre completo: {this.Apellido},{this.Nombre}, Edad: {this.Edad}, DNI: {this.Dni} ");
            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
    }  
}