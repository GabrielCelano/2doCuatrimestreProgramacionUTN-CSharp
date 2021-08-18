using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading;

namespace UnitTestParcial
{
    [TestClass]
    public class Test_Parcial
    {
        [TestMethod]
        [ExpectedException(typeof(ArchivoInvalidoException))]
        public void TestArchivoInvalidoException()
        {
            Paciente paciente = new Paciente();
            Bin<Paciente> bin = new Bin<Paciente>();

            Assert.IsFalse(bin.Leer("Hola", out paciente));
        }

        [TestMethod]
        public void TestLecturaArchivo()
        {
            XML<CentroDeVacunacion> xml = new XML<CentroDeVacunacion>();
            CentroDeVacunacion centro = new CentroDeVacunacion();
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\centrovacunacion.xml";

            Assert.IsTrue(xml.Leer(path, out centro));
        }

        [TestMethod]
        [DataRow("Gabriel", "Celano", 21)]
        [DataRow("Aylen", "Cabano", 30)]
        public void TestSimuladorDeAtencion(string nombre, string apellido, int turno)
        {
            SimuladorDeAtencion<Paciente> simulador = new SimuladorDeAtencion<Paciente>();
            List<Paciente> lista = new List<Paciente>();
            Paciente paciente = new Paciente(apellido, nombre, turno);

            lista.Add(paciente);
            Thread thread = new Thread(simulador.SimularVacunacion);
            thread.Start(lista);
            thread.Abort();
        }
    }
}
