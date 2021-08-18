using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;
using VistaPatentes;
using Patentes;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        public event MostrarPatente muestroPatente;
        Queue<Patente> cola;
        List<Thread> threads;
        public FrmPpal()
        {
            InitializeComponent();
            this.cola = new Queue<Patente>();
            this.threads = new List<Thread>();
            this.muestroPatente += ProximaPatente;
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.muestroPatente += vistaPatente1.MostrarPatente;
            this.muestroPatente += vistaPatente2.MostrarPatente;
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                List<Patente> lp = new List<Patente>();
                Xml<List<Patente>> xml = new Xml<List<Patente>>();
                xml.Leer("patentes", out lp);
                this.cola.Clear();
                this.cola = new Queue<Patente>(lp);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo leer XML", "ERROR XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.IniciarSimulacion();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto texto = new Texto();
                texto.Leer("patentes", out this.cola);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo leer TXT", "ERROR TXT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.IniciarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            try
            {
                List<Patente> lp = new List<Patente>();

                Sql sql = new Sql();
                sql.Leer("patentes", out lp);

                this.cola.Clear();
                this.cola = new Queue<Patente>(lp);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo leer BD SQL", "ERROR SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.IniciarSimulacion();
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread item in threads)
            {
                if (item != null)
                {
                    if (item.IsAlive)
                    {
                        item.Abort();
                    }
                }
            }
        }

        private void IniciarSimulacion()
        {
            this.FinalizarSimulacion();
            while (this.cola.Count > 0)
            {
                this.ProximaPatente(this.cola.Dequeue());
            }
        }

        private void ProximaPatente(object patente)
        {
            if (this.cola.Count > 0)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(muestroPatente.Invoke));
                this.threads.Add(thread);
                thread.Start(patente);
            }
        }
    }
}
