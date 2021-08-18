using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Archivos
{
    public interface IArchivo<T>
    {
        void Guardar(string archivo, T datos);
        void Leer(string archivo, out T datos);

    }
}