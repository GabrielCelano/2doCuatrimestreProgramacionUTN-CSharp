using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Triangulo : Figura
    {
        private ConsoleColor color;
        public Triangulo(double xAltura, double yBase, ConsoleColor color) : base(xAltura, yBase)
        {
            this.color = color;
        }

        public double Area
        {
            get
            {
                return base.CalcularArea();
            }
        }

        public void MostrarDatos()
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine($"Soy un triangulo y mi area es igual a {this.Area}");
        }
    }
}
