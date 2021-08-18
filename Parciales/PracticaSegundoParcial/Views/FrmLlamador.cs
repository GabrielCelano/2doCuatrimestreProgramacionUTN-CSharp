using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FrmLlamador : Form
    {
        private List<Paciente> pacientes;
        private Thread thread;
        private SimuladorDeAtencion<Paciente> simulador;
        public FrmLlamador(List<Paciente> pacientes)
        {
            InitializeComponent();
            this.pacientes = pacientes;
            this.simulador = new SimuladorDeAtencion<Paciente>();
        }

        private void FrmLlamador_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            simulador.AvisoDeUso += MostrarPaciente;
            simulador.FinDeUso += TareaFinalizada;
            this.Atender(this.pacientes);
        }

        private void Atender(List<Paciente> pacientes)
        {
            if (this.thread == null || !this.thread.IsAlive)
            {
                this.thread = new Thread(simulador.SimularVacunacion);
                this.thread.Start(pacientes);
            }
        }

        private void MostrarPaciente(Paciente paciente)
        {
            if (this.InvokeRequired)
            {
                SimuladoDelegate<Paciente> delegado = new SimuladoDelegate<Paciente>(this.MostrarPaciente);
                this.Invoke(delegado, new object[] { paciente });
            }
            else
            {
                this.lblTurno.Text = paciente.Turno.ToString();
                this.lblInfoAdjunta.Text = paciente.ToString();
            }
        }

        public void TareaFinalizada(string mensaje)
        {
            if (this.InvokeRequired)
            {
                FinalDelegate finalDelegate = new FinalDelegate(this.TareaFinalizada);
                this.Invoke(finalDelegate, new object[] { mensaje });
            }
            else
            {
                DialogResult result = MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    if (this.thread.IsAlive)
                    {
                        this.thread.Abort();
                    }
                    this.Close();
                }

            }
        }
    }
}
