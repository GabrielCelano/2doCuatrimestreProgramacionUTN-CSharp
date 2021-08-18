using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso) : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

        public int Antiguedad { get { return (DateTime.Now - fechaIngreso).Days; } }

        protected override bool ValidarDocumentacion(string doc)
        {
            return doc.Length == 8;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ExponerDatos());
            sb.Append($" Antiguedad: {this.Antiguedad}\n\n");
            return sb.ToString();
        }
    }
}