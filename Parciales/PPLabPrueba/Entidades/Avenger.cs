using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Avenger : Personaje
    {
        #region Atributos
        private EEquipamiento equipamiento;
        #endregion

        #region Constructores
        public Avenger(string nombre, List<EHabilidades> hab, EEquipamiento equipo):base(nombre, hab) //Reutilizo el constructor base, pasando por parametro el nombre y la habilidad, e instancio en este constructor el atributo equipamiento
        {
            this.equipamiento = equipo;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// ReadOnly: Retorna el nombre
        /// </summary>
        protected override string Nombre { get { return String.Format($"Mi nombre es {this.nombre} y si no puedo proteger la tierra, la vengare"); } } //Sobreescribe el metodo abstracto de la clase personaje
        #endregion

        #region Metodos
        /// <summary>
        /// Sobreescribe el metodo ToString y devuelve los datos del Avenger
        /// </summary>
        /// <returns></returns>
        public override string InfoPersonajes()
        {
            StringBuilder infoAvenger = new StringBuilder(base.InfoPersonajes());//Instancio un stringbuilder y le paso el metodo ToString de la clase base
            infoAvenger.AppendLine($"\nEquipamiento principal: {this.equipamiento}");//Muestro el equipamiento
            return infoAvenger.ToString();//Retorno el stringbuilder convertido a string
        }
        #endregion
    }
}