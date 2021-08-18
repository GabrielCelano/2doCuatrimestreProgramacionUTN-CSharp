using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }
        public Curso(short anio, Divisiones division, Profesor profesor):this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public string AnioDivision { get { return $"{this.anio}º{this.division}"; } }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder($"Division: {c.AnioDivision}");
            sb.Append($"\nProfesor: {c.profesor.ExponerDatos()}");
            sb.Append("Lista de alumnos:\n");
            foreach (Alumno item in c.alumnos)
            {
                sb.AppendLine(item.ExponerDatos());
            }
            return sb.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            return c.AnioDivision == a.AnioDivision;

            //foreach (Alumno item in c.alumnos)
            //{
            //    if (item.AnioDivision == c.AnioDivision)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }
        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a)
            {
                c.alumnos.Add(a);
                return c;
            }
            return c;
        }
    }
}