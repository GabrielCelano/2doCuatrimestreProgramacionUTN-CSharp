using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public static class Marvel
    {
        private static List<Personaje> listaPersonajes;
        static Marvel()
        {
            listaPersonajes = new List<Personaje>();
        }

        public static Personaje Personaje
        {
            set
            {
                if (listaPersonajes != value)
                {
                    listaPersonajes.Add(value);
                }
            }
        }

        public static string MostrarInformacion()
        {
            StringBuilder auxInfo = new StringBuilder();
            foreach (Personaje item in listaPersonajes)
            {
                if (item is Avenger)
                {
                    auxInfo.AppendLine("******AVENGER******");
                    auxInfo.AppendLine($"{item}");
                }

                else if (item is Enemigo)
                {
                    auxInfo.AppendLine("******ENEMIGO******");
                    auxInfo.AppendLine($"{item}");
                }
            }
            return auxInfo.ToString();
        }
    }
}