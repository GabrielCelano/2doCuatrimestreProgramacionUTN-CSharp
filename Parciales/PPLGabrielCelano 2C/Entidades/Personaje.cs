using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Personaje
    {
        #region Atributos
        private List<EHabilidades> listaHabilidades;
        protected string nombre;
        #endregion

        #region Constructores
        private Personaje() // Constructor privado que instancia la lista de habilidade
        {
            listaHabilidades = new List<EHabilidades>();
        }
        public Personaje(string nombre, List<EHabilidades> habilidades) : this() // Constructor que instancia los atributos de la clase Personaje                                                            
        {
            this.nombre = nombre;
            this.listaHabilidades = habilidades;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// ReadOnly: Retorna el nombre
        /// </summary>
        protected abstract string Nombre { get; }

        /// <summary>
        /// ReadOnly: Retorna la lista de habilidades
        /// </summary>
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
        #endregion

        #region Operadores
        /// <summary>
        /// Si se cumple la igualdad retorno true, caso contrario retorno false
        /// </summary>
        /// <param name="listaPersonajes"></param>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static bool operator ==(List<Personaje> listaPersonajes, Personaje personaje)
        {
            foreach (Personaje item in listaPersonajes)//Recorro la lista de personajes
            {
                if (item.Nombre == personaje.Nombre && item.GetType() == personaje.GetType()) //Dos personajes son iguales si comparten el tipo(Avenger o Enemigo) y el nombre
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Retorna true si se cumple la desigualdad, en caso contrario retorna false
        /// </summary>
        /// <param name="listaPersonajes"></param>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
        {
            return !(listaPersonajes == personaje);// Reutliza el operador == pero niega el retorno, para cumplir la desigualdad
        }

        /// <summary>
        /// Agrega un objeto si este no existe aun en la lista
        /// Retorna la lista
        /// </summary>
        /// <param name="listaPersonajes"></param>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static List<Personaje> operator +(List<Personaje> listaPersonajes, Personaje personaje)
        {
            if (listaPersonajes != personaje) //Reutiliza el operador != para recorrer la lista y verificar si el personaje pasado por parametro se encuentra o no
            {
                listaPersonajes.Add(personaje);//Si no se encuentra en la lista lo agrega a la misma
                return listaPersonajes;
            }
            return listaPersonajes;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreescribe el metodo ToString y devuelve los datos del Avenger
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder infoPersonaje = new StringBuilder(); //Creo un StringBuilder
            infoPersonaje.Append($"{this.Nombre}.\n\n"); //Agrego el nombre del personaje
            infoPersonaje.AppendLine("Lista de habilidades:");
            infoPersonaje.Append(this.ListaHabilidades);//Reutilizo la propiedad ListaHabilidades
            return infoPersonaje.ToString();//Retorno el stringbuilder convertido a string
        }
        #endregion
    }
}