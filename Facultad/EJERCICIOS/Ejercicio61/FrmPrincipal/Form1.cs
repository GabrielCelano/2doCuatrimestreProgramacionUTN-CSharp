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

namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
        private PersonaDAO dao;
        public Form1()
        {
            InitializeComponent();
            this.dao = new PersonaDAO();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                List<Persona> personas = this.dao.GetPersonas("SELECT id, nombre, apellido FROM Personas");
                rtbPersonas.Clear();
                foreach (Persona p in personas)
                {
                    rtbPersonas.Text += p.ToString() + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = new Persona(txtNombre.Text ,txtApellido.Text);
                this.dao.Insert(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLeerPorId_Click(object sender, EventArgs e)
        {
            try
            {
                
                List<Persona> personas = this.dao.GetPersonas($"SELECT * FROM personas WHERE id = {this.nudId.Value.ToString()}");
                rtbPersonas.Clear();
                foreach (Persona p in personas)
                {
                    rtbPersonas.Text += p.ToString() + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = new Persona((int)nudId.Value,txtNombre.Text, txtApellido.Text);
                this.dao.Update(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)nudId.Value;
                this.dao.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
