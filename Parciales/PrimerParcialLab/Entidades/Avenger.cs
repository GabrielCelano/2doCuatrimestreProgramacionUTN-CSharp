using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Avenger : Personaje
    {
        private EEquipamiento equipamiento;
        public Avenger(string nombre, List<EHabilidades> hab, EEquipamiento equipo):base(nombre, hab)
        {
            this.equipamiento = equipo;
        }
        protected override string Nombre { get { return String.Format($"Mi nombre es {this.nombre} y si no puedo proteger la tierra, la vengare"); } }

        public override string ToString()
        {
            StringBuilder infoAvenger = new StringBuilder(base.ToString());
            //infoAvenger.AppendLine($"{this.Nombre}");
            infoAvenger.AppendLine($"\nEquipamiento principal: {this.equipamiento}");
            return infoAvenger.ToString();
        }
    }
}