using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected string nombre;
        protected string marca;
        protected float precio;
        protected string codigo;

        public Producto()
        {
            this.nombre = null;
            this.marca = null;
            this.precio = float.MinValue;
            this.codigo = null;
        }
        
        public Producto(string nombre, string marca, float precio, string codigo)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
            this.codigo = codigo;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }

        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Producto: {0}\n", this.nombre);
            sb.AppendFormat("Marca: {0}\n", this.marca);
            sb.AppendFormat("Precio: ${0}\n", this.precio);
            sb.AppendFormat("Codigo: {0}\n", this.codigo);
            sb.AppendLine("");
            sb.AppendLine("-------------------------------------");
            return sb.ToString();
        }
    }
}
