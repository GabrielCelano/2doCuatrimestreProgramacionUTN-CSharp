using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase { get { return this.nombreClase; } }
        public string NombreMetodo { get { return this.nombreMetodo; } }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException):base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Excepcion en el metodo {this.NombreMetodo} de la clase {this.NombreClase}");

            sb.AppendLine($"Mensaje: {base.Message}");

            return sb.ToString();
        }
    }
}