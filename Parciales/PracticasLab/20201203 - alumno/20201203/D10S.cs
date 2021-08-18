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
using Audio;

namespace _20201203
{
    public partial class D10S : Form
    {
        private Pic estado;
        private GolDelSiglo golDelSiglo;

        public D10S()
        {
            InitializeComponent();
            this.golDelSiglo = new GolDelSiglo();
            Relato.Avanzar += MostrarGrafico;
        }

        private void MostrarGrafico()
        {
            if (this.InvokeRequired)
            {
                AvanceRelato delegado = new AvanceRelato(this.MostrarGrafico);
                this.Invoke(delegado);
            }
            else
            {
                switch (estado)
                {
                    case Pic.SePrepara:
                        this.picFondo.Visible = false;
                        break;
                    case Pic.LaTieneMaradona:
                        pic1.Visible = true;
                        break;
                    case Pic.ArrancaConLaPelota:
                        pic1.Visible = false;
                        pic2.Visible = true;
                        break;
                    case Pic.DejaElTendal:
                        pic2.Visible = false;
                        pic3.Visible = true;
                        break;
                    case Pic.VaATocarPara:
                        pic3.Visible = false;
                        pic4.Visible = true;
                        break;
                    case Pic.Gooool:
                        pic4.Visible = false;
                        pic5.Visible = true;
                        break;
                    case Pic.Festeja:
                        pic5.Visible = false;
                        this.picFondo.Visible = true;
                        this.picFondo.Visible = true;
                        estado--;
                        break;
                }
                estado++;
            }
        }

        private void btnGolDelSiglo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!object.ReferenceEquals(this.golDelSiglo, null))
                    this.golDelSiglo.IniciarJugada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void D10S_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea cerrar?", "Cerrar gol del siglo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.golDelSiglo.CerrarApp();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void btnGuardarLog_Click(object sender, EventArgs e)
        {
            Texto texto = new Texto();
            Sql sql = new Sql();
            string datos = string.Format($"Se disfrutó el gol del siglo a las {DateTime.Now.ToString("hh:mm")} hs");
            texto.Guardar("log.txt", datos);
            sql.Insert(datos);
        }

        private void btnLeerLog_Click(object sender, EventArgs e)
        {
            string datos = "";
            Texto texto = new Texto();
            Sql sql = new Sql();
            List<string> lista = new List<string>();
            if (texto.Leer("log.txt", out datos))
            {
                MessageBox.Show(datos, "Archivo de texto");
            }
            lista = sql.LeerRegistrosCompleto();

            foreach (string item in lista)
            {
                MessageBox.Show(item, "Base de datos");
            }
        }
    }
}
