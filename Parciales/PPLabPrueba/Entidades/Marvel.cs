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
        private static int cantidadPersonajes;
        private static string guardarAlgo;
        #endregion

        #region Constructores
        /// <summary>
        /// Instancia la lista de personajes
        /// </summary>
        static Marvel()
        {
            listaPersonajes = new List<Personaje>();
            cantidadPersonajes = 0;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Setea un personaje mientras este no exista en la lista
        /// </summary>
        /// <exception cref="AgregarPersonajeException"></exception>
        public static Personaje Personaje
        {
            set
            {
                guardarAlgo = "";
                try //Si puede haber una excepcion hago un try
                {
                    listaPersonajes = listaPersonajes + value;//Si no se encuentra lo agrego
                    //Si hay excepcion no se ejecuta lo demas que hay en el try hasta llegar al catch
                    cantidadPersonajes++;
                }
                catch (PersonajeRepetidoException objetoExceptionCapturada) //Si hay una una excepcion la captura catch(ponemos el tipo de excepcion que se esta esperando)
                {
                    throw new AgregarPersonajeException("No se pudo agregar", objetoExceptionCapturada);//Ordenamos que hacer si existe esta excepcion

                    //Escribir en el log en el error;(cuando se vea archivos)
                }
                catch (ExcesoDePersonajesException objetoExcesoExceptionCapturada)
                {
                    throw new AgregarPersonajeException("No se pudo agregar", objetoExcesoExceptionCapturada);
                }
                catch (Exception ex)//Esto es lo mas usado, pero no recomendado
                {
                    throw new AgregarPersonajeException("No se pudo agregar", ex);
                }
                finally
                {
                    guardarAlgo = "Esto tiene que estar si o si";
                }

                guardarAlgo = "llegue al final";
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
                    auxInfo.AppendLine($"{item.InfoPersonajes()}");
                }

                else if (item is Enemigo)//Si de tipo Enemigo muestro los datos
                {
                    auxInfo.AppendLine("******ENEMIGO******");
                    auxInfo.AppendLine($"{item.InfoPersonajes()}");
                }
            }
            return auxInfo.ToString();//Retorno el StringBuilder convertido a string
        }
        #endregion
    }
}