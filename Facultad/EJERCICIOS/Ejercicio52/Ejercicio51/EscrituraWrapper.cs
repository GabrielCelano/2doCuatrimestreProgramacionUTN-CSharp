using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio51
{
    public class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }
    }
}