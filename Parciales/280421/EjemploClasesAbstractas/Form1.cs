using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace EjemploClasesAbstractas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacturaA f1 = new FacturaA("pepe","1");
            FacturaB f2 = new FacturaB("epep","2");
            FacturaC f3 = new FacturaC("eepp","3");
            //Factura as = new Factura("Jorge");   NO SE PUEDE INSTANCIAR UNA CLASE ABSTRACTA,  se puede heredar

            MessageBox.Show(f1.RetornarNumeroDeCuit());
            MessageBox.Show(f2.RetornarNumeroDeCuit());
            MessageBox.Show(f3.RetornarNumeroDeCuit());
        }
    }
}
