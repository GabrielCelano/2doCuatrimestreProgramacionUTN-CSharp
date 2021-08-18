using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ejercicio42;

namespace UnitTestEjercicio45
{
    [TestClass]
    public class TestEjercicio45
    {
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void PruebaInstancia()
        {
            OtraClase obj;

            obj = new OtraClase();
            obj.MetodoInstancia();

            Assert.IsNotNull(obj);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void PruebaMetodoEstatico()
        {
            MiClase obj;

            obj = new MiClase();

            Assert.IsNotNull(obj);
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void PruebaMiClase()
        {
            MiClase obj;

            obj = new MiClase(50);

            Assert.IsNotNull(obj);
        }
    }
}
