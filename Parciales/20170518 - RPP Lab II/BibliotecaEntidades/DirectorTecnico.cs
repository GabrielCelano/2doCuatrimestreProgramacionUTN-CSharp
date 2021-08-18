using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class DirectorTecnico:Persona
    {
        public DirectorTecnico(string nombre, string apellido) : base(nombre, apellido)
        {

        }

        protected override string FichaTecnica()
        {
            return String.Format($"DT: {this.Nombre} {this.Apellido}");
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }
    }
}