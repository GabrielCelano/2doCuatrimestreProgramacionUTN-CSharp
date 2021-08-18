using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        public Cantina(int espacios)
        {
            this.espaciosTotales = espacios;
            botellas = new List<Botella>();
        }

        public List<Botella> Botellas { get { return this.botellas; } }

        public static Cantina GetCantina(int espacios)
        {
            if (singleton is null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espaciosTotales += espacios;
            }
            return singleton;
        }

        public static bool operator +(Cantina c, Botella b)
        {
            if (c.botellas.Count < c.espaciosTotales)
            {
                c.botellas.Add(b);
                return true;
            }
            return false;
        }
    }
}