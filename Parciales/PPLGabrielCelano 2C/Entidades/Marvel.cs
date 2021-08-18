using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public static class Marvel
    {
        #region Atributos
        private static List<Personaje> listaPersonajes;
        #endregion

        #region Constructores
        /// <summary>
        /// Instancia la lista de personajes
        /// </summary>
        static Marvel()
        {
            listaPersonajes = new List<Personaje>();
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Setea un personaje mientras este no exista en la lista
        /// </summary>
        public static Personaje Personaje
        {
            set
            {         
               listaPersonajes = listaPersonajes + value;//Si no se encuentra en la lista lo agrego
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna la lista de personajes
        /// </summary>
        /// <returns></returns>
        public static string MostrarInformacion()
        {
            StringBuilder auxInfo = new StringBuilder();//Instancio un StringBuilder
            foreach (Personaje item in listaPersonajes)//Recorro la lista de personajes
            {
                if (item is Avenger)//Si de tipo Avenger muestro los datos
                {
                    auxInfo.AppendLine("******AVENGER******");
                    auxInfo.AppendLine($"{item}");
                }

                else if (item is Enemigo)//Si de tipo Enemigo muestro los datos
                {
                    auxInfo.AppendLine("******ENEMIGO******");
                    auxInfo.AppendLine($"{item}");
                }
            }
            return auxInfo.ToString();//Retorno el StringBuilder convertido a string
        }
        #endregion
    }
}