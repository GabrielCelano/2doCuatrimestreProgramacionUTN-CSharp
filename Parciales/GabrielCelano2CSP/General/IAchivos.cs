using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public interface IAchivos<T>
    {
        bool Guardar(string archivo, T datos);
        List<T> Leer(string archivo, List<T> lista);
    }
}
