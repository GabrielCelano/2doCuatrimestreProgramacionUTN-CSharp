using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio50
{
    public class Serializar<S, V> : IGuardar<T, V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Objeto Leido", typeof(V));
        }
    }
}