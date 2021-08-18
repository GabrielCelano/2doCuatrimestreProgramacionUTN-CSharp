using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCarrera
{
    [TestClass]
    public class ArchivosTest
    {
        [TestMethod]
        public void SerializarXmlTest()
        {
            GestorDeArchivos gestor = new GestorDeArchivos("TestUnitarioXml.xml");
            Carrera carrera = new Carrera();
            gestor.Guardar(carrera);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoException))]
        public void LeerXmlTest()
        {
            GestorDeArchivos gestor = new GestorDeArchivos("HolaMundo");
            gestor.LeerXML();
        }
    }
}
