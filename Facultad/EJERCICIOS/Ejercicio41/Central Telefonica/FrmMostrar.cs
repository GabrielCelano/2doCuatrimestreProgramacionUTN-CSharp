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
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private Llamada.TipoLlamada tipoLlamada;
        public FrmMostrar(Llamada.TipoLlamada tipoLlamada)
        {
            InitializeComponent();
            this.tipoLlamada = tipoLlamada;
        }

        public Centralita Centralita { set { this.centralita = value; } }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            foreach (Llamada item in this.centralita.Llamadas)
            {
                if (item is Local && this.tipoLlamada == Llamada.TipoLlamada.Local)
                {
                    this.rchInforme.Text += item.ToString();
                }
                else if (item is Provincial && this.tipoLlamada == Llamada.TipoLlamada.Provincial)
                {
                    this.rchInforme.Text += item.ToString();
                }
                else if (this.tipoLlamada == Llamada.TipoLlamada.Todas)
                {
                    this.rchInforme.Text += item.ToString();
                }
            }

            if (this.tipoLlamada == Llamada.TipoLlamada.Local)
            {
                this.rchInforme.Text += $"Ganancia local total: {this.centralita.GananciasPorLocal}";
            }
            else if (this.tipoLlamada == Llamada.TipoLlamada.Provincial)
            {
                this.rchInforme.Text += $"Ganancia provincial total: {this.centralita.GananciasPorProvincial}";
            }
            else if (this.tipoLlamada == Llamada.TipoLlamada.Todas)
            {
                this.rchInforme.Text += $"Ganancia total: {this.centralita.GananciasPorTotal}";
            }
        }
    }
}
