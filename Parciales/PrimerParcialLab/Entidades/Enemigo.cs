using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Enemigo : Personaje
    {
        private string objetivo;
        public Enemigo(string nombre, List<EHabilidades> hab, string objetivo):base(nombre, hab)
        {
            this.objetivo = objetivo;
        }
        protected override string Nombre { get { return String.Format($"Soy {this.nombre} y los voy a hacer puré"); } }

        public override string ToString()
        {
            StringBuilder infoEnemigo = new StringBuilder(base.ToString());
            //infoEnemigo.AppendLine($"{this.Nombre}");
            infoEnemigo.AppendLine($"\nObjetivo: {this.objetivo}");
            return infoEnemigo.ToString();
        }
    }
}