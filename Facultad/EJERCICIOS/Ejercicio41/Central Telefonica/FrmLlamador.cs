using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Central_Telefonica
{
    public partial class FrmLlamador : Form
    {
        protected Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.cmbFranja.Enabled = false;
        }

        //Metodos para ir cargando el destino
        #region Metodos carga de numeros
        private void CargarNumero(string numeroIngresado)
        {
            if (this.txtNroDestino.Text == "Nro Destino")
            {
                this.txtNroDestino.Text = string.Empty;
            }
                this.txtNroDestino.Text += numeroIngresado;            
        }
        private void BtnUno_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnUno.Text);
        }

        private void BtnDos_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnDos.Text);
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnTres.Text);
        }

        private void BtnCuatro_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnCuatro.Text);
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnCinco.Text);
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnSeis.Text);
        }

        private void BtnSiete_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnSiete.Text);
        }

        private void BtnOcho_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnOcho.Text);
        }

        private void BtnNueve_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnNueve.Text);
        }

        private void BtnCero_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnCero.Text);
        }

        private void BtnAsterisco_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnAsterisco.Text);
        }

        private void BtnNumeral_Click(object sender, EventArgs e)
        {
            this.CargarNumero(this.BtnNumeral.Text);
        }

        #endregion

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (Verificacion(this.txtNroDestino.Text))
            {
                this.cmbFranja.Enabled = true;
            }

            else
            {
                this.cmbFranja.Enabled = false;
            }
        }

        private bool Verificacion(string txt)
        {
            if (txt.IndexOf('#') == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TxtNroOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo ingresar numeros.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLlamar_Click(object sender, EventArgs e)
        {
            Random nroRandom = new Random();
            float duracion = (float)nroRandom.Next(1, 50);
            Llamada nuevaLlamada;
            Provincial.Franja franjas;
            //Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedItem.ToString(), out franjas);
            if (Verificacion(this.txtNroDestino.Text) && Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedItem.ToString(), out franjas))
            {
                nuevaLlamada = new Provincial(this.txtNroOrigen.Text, franjas, duracion, this.txtNroDestino.Text);
            }
            else
            {
                float costo = ((float)nroRandom.Next(5, 56) / 10 );
                nuevaLlamada = new Local(this.txtNroOrigen.Text, duracion, this.txtNroOrigen.Text, costo);
            }

            this.centralita += nuevaLlamada;
        }
    }
}
