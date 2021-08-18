using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Personaje
    {
        private List<EHabilidades> listaHabilidades;
        protected string nombre;

        private Personaje()
        {
            listaHabilidades = new List<EHabilidades>();
        }
        public Personaje(string nombre, List<EHabilidades> habilidades)
        {
            this.nombre = nombre;
            this.listaHabilidades = habilidades;
        }

        protected abstract string Nombre{ get; }
        private string ListaHabilidades 
        {
            get
            {
                StringBuilder auxHabilidades = new StringBuilder();
                foreach (EHabilidades item in listaHabilidades)
                {
                    auxHabilidades.AppendLine(item.ToString());
                }
                return auxHabilidades.ToString();
            }
        }

        public static bool operator ==(List<Personaje> listaPersonajes, Personaje personaje)
        {
            bool aux = false;
            foreach (Personaje item in listaPersonajes)
            {
                if (item.Nombre == personaje.Nombre)
                {
                    aux = item.GetType() == personaje.GetType();
                }
            }
            return aux;
        }

        public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
        {
            return !(listaPersonajes == personaje);
        }

        public static List<Personaje> operator +(List<Personaje> listaPersonajes, Personaje personaje)
        {
            if (listaPersonajes != personaje)
            {
                listaPersonajes.Add(personaje);
                return listaPersonajes;
            }
            return listaPersonajes;
        }

        public override string ToString()
        {
            StringBuilder infoPersonaje = new StringBuilder();

            infoPersonaje.Append($"Nombre: {this.Nombre}.\n\n");
            infoPersonaje.AppendLine("Lista de habilidades:");
            //foreach (EHabilidades item in listaHabilidades)
            //{
            //    infoPersonaje.AppendLine(item.ToString());
            //}
            infoPersonaje.Append(this.ListaHabilidades);
            return infoPersonaje.ToString();
        }
    }
}