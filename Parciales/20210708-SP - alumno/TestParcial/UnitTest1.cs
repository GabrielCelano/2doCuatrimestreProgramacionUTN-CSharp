using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestParcial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArchivoInvalidoException))]
        public void TestArchivoInvalidoException()
        {

        }
    }
}
