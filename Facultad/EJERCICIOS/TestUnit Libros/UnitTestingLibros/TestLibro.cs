using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AppLibro;
using System.Collections.Generic;

namespace UnitTestingLibros
{
    [TestClass]
    public class TestLibro
    {
        [TestMethod]
        public void TituloDelLibro()
        {
            Libro libro = new Libro();
            string titulo = "ElSeñorDeLosAnillos";

            libro.Titulo = titulo;

            Assert.IsNotNull(libro.Titulo);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TituloDelLibroNull()
        {
            Libro libro = new Libro();

            libro.Titulo = null;

            Assert.IsNull(libro.Titulo);
        }

        [TestMethod]
        public void BuscarTexto()
        {
            Libro libro = new Libro();
            List<Hoja> hoja;

            hoja = libro.Buscar(null);

            Assert.IsTrue(hoja.Count == 0);
        }


        [TestMethod]
        [DataRow("Hola", "Chau")]
        [DataRow(null, "Chau")]
        [DataRow("Hola", null)]
        public void Remplazar(string buscado, string reemplazo)
        {
            Libro libro = new Libro();
            List<Hoja> hoja;

            hoja = libro.Reemplazar(buscado, reemplazo);

            Assert.IsTrue(hoja.Count == 0);
        }

        [TestMethod]
        public void HojasConMasRenglones()
        {
            Libro libro = new Libro();
            List<Hoja> hojas = new List<Hoja>();

            hojas = libro.TraerHojasConMasRenglones();

            Assert.IsTrue(hojas.Count == 2);
        }

        [TestMethod]
        public void EliminaHojasRepetidas()
        {
            Libro libro = new Libro();
            List<Hoja> hojasEliminadas = new List<Hoja>();

            hojasEliminadas = libro.EliminarHojasRepetidas();

            Assert.IsTrue(hojasEliminadas.Count == 2);
        }
    }
}
