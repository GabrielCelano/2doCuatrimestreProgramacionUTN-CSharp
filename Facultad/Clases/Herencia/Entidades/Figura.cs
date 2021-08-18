using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Figura
    {
        protected double xAltura;
        protected double yBase;

        public Figura(double xAltura, double yBase)
        {
            this.xAltura = xAltura;
            this.yBase = yBase;
        }

        protected double CalcularArea()
        {
            double returnArea = 0;
            if (this is Triangulo)
            {
                returnArea = (this.yBase * this.xAltura) / 2;
            }
            else if (this is Rectangulo)
            {
                returnArea = this.yBase * this.xAltura;
            }
            return returnArea;
        }
    }
}
