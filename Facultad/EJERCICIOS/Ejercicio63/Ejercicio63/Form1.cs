using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer = new Timer();
            timer.Tick += new EventHandler(this.AsignarHora);
            timer.Start();
           
        }

        public void AsignarHora(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }
    }
}
