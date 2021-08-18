using _20201203;
using Audio;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(JugadaActivaException))]
        public void TestJugadaActivaException()
        {
            //arrange
            GolDelSiglo obj = new GolDelSiglo();
            //act
            obj.IniciarJugada();
            //assert es manejado en el ExpectedException
        }

        [TestMethod]
        public void TestMetodoDeExtension()
        {
            //arrange
            PictureBox pic = new PictureBox();
            pic.Name = "pic1";
            string ultimoCaracter = pic.Name.Substring(pic.Name.Length - 1, 1);
            string retornoMetodo;
            //act
            retornoMetodo = pic.ExtensionPicture();
            //assert 
            Assert.AreEqual(ultimoCaracter, retornoMetodo);
        }
    }
}
