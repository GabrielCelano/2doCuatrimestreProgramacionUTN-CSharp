using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (Equipo item in torneo.equipos)
            {
                if (equipo == item)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return torneo;
            }
            return torneo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre del torneo: {this.nombre}\n\n");
            sb.AppendLine("Equipos:");
            foreach (Equipo item in this.equipos)
            {
                sb.AppendLine($"{item.Ficha()}");
            }
            return sb.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random random = new Random();
            int num1;
            int num2;
            if (e1 is EquipoBasquet && e2 is EquipoBasquet)
            {
                num1 = random.Next(0, 150);
                num2 = random.Next(0, 150);
            }
            else
            {
                num1 = random.Next(0, 10);
                num2 = random.Next(0, 10);
            }

            return $"{e1.Nombre}: {num1} - {num2} :{e2.Nombre}";
        }
        public string JugarPartido()
        {
            Random random = new Random();
            int num1 = 0;
            int num2 = 0;
            while (num1 == num2)
            {
                num1 = random.Next(0, 3);
                num2 = random.Next(0, 3);
            }

            return CalcularPartido(this.equipos[num1], this.equipos[num2]);
        }
    }
}
