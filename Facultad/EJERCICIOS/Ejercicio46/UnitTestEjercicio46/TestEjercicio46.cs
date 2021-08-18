using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace UnitTestEjercicio46
{
    [TestClass]
    public class TestEjercicio46
    {
        /// <summary>
        /// Crear un test unitario que valide que la lista de vehículos de la competencia esté instanciada
        /// al crear un nuevo objeto.
        /// </summary>
        [TestMethod]
        public void ListaInstanciada()
        {
            Competencia competidores;

            competidores = new Competencia(50, 5, TipoCompetencia.F1);

            Assert.IsNotNull(competidores.Competidores);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void CompetenciaMotocross()
        {
            bool competenciaMoto;
            AutoF1 f1;
            MotoCross m1;
            Competencia comp;

            f1 = new AutoF1(44, "Mercedes Benz");
            m1 = new MotoCross(10, "Yamaha");
            comp = new Competencia(50, 5, TipoCompetencia.MotoCross);
            competenciaMoto = comp + m1;


            Assert.IsFalse(comp + f1);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        //[ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void CompetenciaFormula1()
        {
            bool competenciaMoto;
            AutoF1 f1;
            MotoCross m1;
            Competencia comp;

            f1 = new AutoF1(44, "Mercedes Benz");
            m1 = new MotoCross(10, "Yamaha");
            comp = new Competencia(50, 5, TipoCompetencia.MotoCross);
            competenciaMoto = comp + f1;


            Assert.IsFalse(comp + f1);
        }
    }
}
