using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock) : this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe) : this(nombre, stock)
        {
            this.importe = importe;
        }

        protected abstract bool EsColor { get; }
        public virtual bool HayStock
        {
            get
            {
                if (Stock > 0 && Importe > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public float Importe { get; }
        public int Stock
        {
            get
            {
                return this.stock;
            }

            set
            {
                if (value > 0)
                {
                    this.stock = value;
                }
            }
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public string Imformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Stock: {this.stock}");
            sb.AppendLine($"Color: {this.EsColor}");
            sb.AppendLine($"Valor: ${this.importe}");
            return sb.ToString();
        }
    }
}