using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaSegundoParcialProg;
using System;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
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
