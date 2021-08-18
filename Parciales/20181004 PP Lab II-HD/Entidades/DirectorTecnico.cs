using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) :base(nombre,apellido,edad,dni)
        {
            this.AñosExperiencia = añosExperiencia;
        }

        public int AñosExperiencia { get { return this.añosExperiencia; } set { this.añosExperiencia = value; } }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nDT: {base.Mostrar()}");
            sb.AppendLine($" Años de experiencia: {this.AñosExperiencia}");
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            if (this.AñosExperiencia >= 2)
            {
                return this.Edad < 65;
            }
            return false;
        }

    }
}