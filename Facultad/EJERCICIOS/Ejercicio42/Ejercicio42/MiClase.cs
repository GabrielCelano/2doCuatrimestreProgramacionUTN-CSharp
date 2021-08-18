using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiClase
    {
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("Metodo Estatico()"); //Se lanza una exepcion
        }

        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico(); //Capturo una exepcion 
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }

        public MiClase(int num)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("MiClase(int num)", ex);
            }
        }
    }
}
