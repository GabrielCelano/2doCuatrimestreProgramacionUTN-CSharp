using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;
        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division) : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public string AnioDivision { get { return $"{this.anio}º{this.division}"; } }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool rtn = false;
            string[] str;

            if (doc.Contains('-'))
            {
                str = doc.Split('-');

                if (str.Length == 3 && str[0].Length == 2 && str[1].Length == 4 && str[2].Length == 1)
                {
                    rtn = true;
                    for (int i = 0; i < str.Length; i++)
                    {
                        for (int j = 0; j < str[i].Length; j++)
                        {
                            if (!char.IsNumber((str[i])[j]))
                            {
                                rtn = false;
                                break;
                            }
                        }
                    }
                }
            }
            return rtn;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ExponerDatos());
            sb.Append($" Año: {this.AnioDivision}");
            return sb.ToString();
        }
    }
}