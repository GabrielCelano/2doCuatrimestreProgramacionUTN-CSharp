using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Enemigo : Personaje
    {
        #region Atributos
        private string objetivo;
        #endregion

        #region Constructores
        public Enemigo(string nombre, List<EHabilidades> hab, string objetivo):base(nombre, hab)//Reutilizo el constructor base, pasando por parametro el nombre y la habilidad, e instancio en este constructor el atributo objetivo
        {
            this.objetivo = objetivo;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// ReadOnly: Retorna el nombre
        /// </summary>
        protected override string Nombre { get { return String.Format($"Soy {this.nombre} y los voy a hacer puré"); } } //Sobreescribe el metodo abstracto de la clase personaje
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreescribe el metodo ToString y devuelve los datos del Enemigo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder infoEnemigo = new StringBuilder(base.ToString());// Instancio un stringbuilder y le paso el metodo ToString de la clase base
            infoEnemigo.AppendLine($"\nObjetivo: {this.objetivo}");//Muestro el objetivo
            return infoEnemigo.ToString();//Retorno el stringbuilder convertido a string
        }
        #endregion
    }
}