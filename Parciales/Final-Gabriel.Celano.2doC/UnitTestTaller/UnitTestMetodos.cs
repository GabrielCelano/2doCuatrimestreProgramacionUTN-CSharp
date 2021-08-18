using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.IO;

namespace UnitTestTaller
{
    [TestClass]
    public class UnitTestMetodos
    {
        [TestMethod]
        public void TestFactura()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\FinalLab2\\" + $"Factura_39958895.txt";
            Administrativo administrativo = new Administrativo("Celano", "Gabriel");
            Cliente cliente = new Cliente(39958895, "Cabano", "Aylen");

            administrativo.Atender(cliente);

            Assert.IsTrue(File.Exists(path));
        }


        [TestMethod]
        public void TestClienteAtendido()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\FinalLab2\\" + $"17611067_ClienteAtendido.xml";
            Mecanico mecanico = new Mecanico(39958895, "Gabriel", "Celano");
            Cliente cliente = new Cliente(17611067, "Cabano", "Aylen");

            mecanico.Atender(cliente);

            Assert.IsTrue(File.Exists(path));
        }


    }
}
