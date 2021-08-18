using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Vendedor v, Publicacion p)
        {
            if (p.HayStock)
            {
                v.ventas.Add(p);
                p.Stock -= 1;
                return true;
            }
            return false;
        }

        public string InformeDeVentas(Vendedor v)
        {
            double gananciaTotal = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this.nombre}");
            foreach (Publicacion item in v.ventas)
            {
                sb.AppendLine("--------------------------------------");
                sb.AppendLine($"PUBLICACION: {item.Imformacion()}");
                sb.AppendLine("--------------------------------------");
                gananciaTotal += item.Importe;
            }
            sb.AppendLine($"Ganancia Total: ${gananciaTotal}");
            return sb.ToString();
        }
    }
}