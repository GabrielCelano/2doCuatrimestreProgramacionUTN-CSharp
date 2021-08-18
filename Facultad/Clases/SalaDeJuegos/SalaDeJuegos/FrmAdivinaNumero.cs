using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaDeJuegos
{
    public partial class FrmAdivinaNumero : Form
    {
        int numeroSecreto;
        Random aleatorio;
        byte contador;
        int maximo;
        public FrmAdivinaNumero()
        {
            InitializeComponent();
            this.aleatorio = new Random();
            this.contador = 0;
            this.numeroSecreto = 0;
            this.maximo = 0;
        }

        private void btnMostrarRandom_Click(object sender, EventArgs e)
        {
            adivinarNumero(this.txtNumeroIngresado.Text, contador);           
        }

        private void FrmAdivinaNumero_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.chkIntentos.Enabled = false;
            this.grpNivel.Enabled = false;
            bool validarBoton = false;

            foreach (Control item in grpNivel.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    maximo = int.Parse(((RadioButton)item).Text);
                    validarBoton = true;
                    numeroSecreto = aleatorio.Next(1, maximo);
                }
            }

            if (validarBoton)
            {
                if (this.chkIntentos.Checked)
                {
                    this.contador = 5;
                }
                //((Button)sender).Visible = false;
                this.btnMostrarRandom.Visible = true;
            }
            else
            {
                MessageBox.Show("Primero debe ingresar un nivel!.");
                this.Close();
            }
        }

        public void adivinarNumero(string numeroIngresado, int contador)
        {
            int numeroConvertido = 0;
            if (contador > 0)
            {
                if (int.TryParse(numeroIngresado, out numeroConvertido))
                {
                    if (numeroSecreto == numeroConvertido)
                    {
                        MessageBox.Show("Adivinaste!!");
                        this.Close();
                    }

                    else
                    {
                        contador--;
                        MessageBox.Show("Incorrecto.");
                        MessageBox.Show("Te quedan: " + contador + " intentos!.");
                        if (contador <= 0)
                        {
                            this.Close();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Ingresar solo numeros");
                }
            }

            else
            {
                if (int.TryParse(numeroIngresado, out numeroConvertido))
                {
                    if (numeroSecreto == numeroConvertido)
                    {
                        MessageBox.Show("Adivinaste!!");
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Incorrecto.");
                    }
                }

                else
                {
                    MessageBox.Show("Ingresar solo numeros");
                }
            }
        }

        private void grpNivel_Enter(object sender, EventArgs e)
        {

        }
    }
}
