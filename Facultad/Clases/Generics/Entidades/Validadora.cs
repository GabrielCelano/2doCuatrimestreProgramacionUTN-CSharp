using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validadora
    {
        /*
        public static Producto inicializarProducto(Producto producto)
        {
            return producto ?? new Producto(); //si es null retorna la izquierda y si no es null retorna la derecha
        }

        public static Cliente inicializarCliente(Cliente cliente)
        {
            return cliente is null ? new Cliente() : cliente; //if / else if todo lo anterior al signo de pregunta, le sigue lo que hay despues del ?, else cliente
        }
        */

        public static T inicializarElemento<T>(T valor) where T : new()
        {
            if (valor == null)
                return new T();
            else
                return valor;
        }

        public static bool validarProducto(Producto producto)
        {   /*
            if (producto.Nombre != "" &&
                producto.Marca != "" &
                producto.Precio != float.MinValue &&
                producto.Codigo != "") return true;


            else return false;
            */
            return !String.IsNullOrWhiteSpace(producto.Nombre);
        }

        public static bool validarCliente(Cliente cliente)
        {
            /*
            if (cliente.Nombre != "" &&
                cliente.Apellido != "" &&
                cliente.Dni != "") return true;

            else return false;
            */

            return !String.IsNullOrWhiteSpace(cliente.Nombre); //Indica si la cadena es null, esta vacia o solo tiene espacios
        }
    }
}
