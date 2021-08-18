using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {
            try
            {
                new MiClase(10);
            }
            catch (UnaExcepcion e)
            {
                throw new MiExcepcion("MetodoInstancia()", e);
            }
        }
    }
}
