using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private TipoManada tipo;
        public enum TipoManada { Unica, Mixta };

        private Grupo()
        {
            this.tipo = TipoManada.Unica;
            this.manada = new List<Mascota>();
        }
        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {
            this.tipo = tipo;
        }

        public TipoManada Tipo { set { this.tipo = value; } }

        public static bool operator ==(Grupo e, Mascota j)
        {
            foreach (Mascota item in e.manada)
            {
                if (item.GetType() == j.GetType() && item == j)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            if (e != j)
            {
                e.manada.Add(j);
            }
            return e;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            if (e == j)
            {
                e.manada.Remove(j);
            }
            return e;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder($"**{e.nombre} {e.tipo}**\nIntegrantes:\n");
            e.manada.ForEach(k => sb.AppendLine(k.ToString()));

            return sb.ToString();
        }
    }
}