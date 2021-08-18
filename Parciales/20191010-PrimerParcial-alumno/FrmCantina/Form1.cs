using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEntidades;
using ControlCantina;

namespace FrmCantina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella botella;
            int capacidad = (int)numericUpDownCapacidad.Value;
            int contenido = (int)numericUpDownContenido.Value;
            string marca = txtMarca.Text;
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);

            if (this.rdoAgua.Checked == true)
            {
                barra.AgregarBotella(botella = new Agua(capacidad, marca, contenido));
            }
            else if (this.rdoCerveza.Checked == true)
            {
                barra.AgregarBotella(botella = new Cerveza(capacidad, marca, tipo, contenido));
            }
            else
            {
                MessageBox.Show("Primero seleccionar:\nCerveza\nAgua", "Alerta!.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
