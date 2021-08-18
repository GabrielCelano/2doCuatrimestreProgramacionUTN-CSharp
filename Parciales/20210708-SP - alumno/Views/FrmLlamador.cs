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
        private List<Paciente> listaPacientes;
        SimuladorDeAtencion<Paciente> simulador;
        private Thread hiloAtender;
        public FrmLlamador(List<Paciente> pacientes)
        {
            InitializeComponent();
            this.listaPacientes = pacientes;
            simulador = new SimuladorDeAtencion<Paciente>();
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
            //simulador.AvisoDeUso += MostrarPaciente;
            simulador.AvisoDeUso += MostrarPaciente;
            //simulador.FinDeUso += TareaFinalizada;
            this.ComenzarAtender(this.listaPacientes);
        }

        private void ComenzarAtender(List<Paciente> pacientes)
        {
            //simulador.AvisoDeUso += MostrarPaciente;
            //simulador.FinDeUso += TareaFinalizada;
            if (this.hiloAtender == null || !this.hiloAtender.IsAlive)
            {
                this.hiloAtender = new Thread(simulador.SimularVacunacion);
                this.hiloAtender.Start(pacientes);
            }
        }


        private Paciente MostrarPaciente(Paciente paciente)
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
            return paciente;
        }

        public string TareaFinalizada(string mensaje)
        {
            return mensaje;
        }
    }
}
