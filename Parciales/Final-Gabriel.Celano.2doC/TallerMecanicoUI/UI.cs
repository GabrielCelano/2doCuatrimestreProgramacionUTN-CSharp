using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace TallerMecanicoUI
{
    public partial class UI : Form
    {
        /// <summary>
        /// Aqui deberá crearse el hilo secundario.
        /// </summary>
        private Thread thread;
        private int clientesAtendidos;

        /// <summary>
        /// Aqui deberá instanciarse el hilo secundario
        /// que iniciara la LLAMADA DE CLIENTES luego en Iniciar_Click.
        /// </summary>
        public UI()
        {
            InitializeComponent();
            clientesAtendidos = 0;
            this.thread = new Thread(this.LlamarClientes);
        }


        /// <summary>
        /// Estye metodo deberá comprobar si la ruta MISDOCUMENTOS/FinalLab2 existe. Si no existe,deberá
        /// arrojar una exception personalidaza por el alumno de tipo DirectorioNoCreadoException.
        /// Dentro del catch de esa exception se creará el directorio.
        /// 
        ///  Si el directorio existe, se iniciará el hilo secundario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\\FinalLab2\\";
            try
            {
                this.lbl_MensajeAtencion.Visible = true;
                this.rtb_Clientes.Visible = true;
                if (Directory.Exists(ruta))
                {
                    thread.Start();
                }
                else
                {
                    throw new DirectorioNoCreadoException();
                }
            }

            catch (Exception ex)
            {
                Directory.CreateDirectory(ruta);
                MessageBox.Show(ex.Message);
            }

        }


        /// <summary>
        ///  Iterará la lista de clientes para ACTUALIZAR LOS CAMPOS en pantalla
        ///  Luego hará que PASE EL SIGUIENTE.
        ///  Esto sucederá hasta haber atendido a todos los clientes
        /// </summary>
        private void LlamarClientes()
        {
            foreach (Cliente item in Taller.ListaClientes)
            {
                this.ActualizarCampo(item);
                Taller.PaseElSiguiente(item);
            }
        }


        /// <summary>
        /// Este metodo actualizará el label ClientesAtendidos
        /// con la cantidad de clientes atendidos hasta el momento.
        /// Luego mostrará en el richTextBox Clientes la informacion de ese cliente
        /// </summary>
        /// <param name="item"></param>
        private void ActualizarCampo(Cliente item)
        {
            if (this.InvokeRequired)
            {
                AtenderCliente atenderClienteDelegado = new AtenderCliente(this.ActualizarCampo);
                this.Invoke(atenderClienteDelegado, new object[] { item });
            }
            else
            {
                lb_ClientesAtendidos.Text = clientesAtendidos++.ToString();
                rtb_Clientes.Text = item.ToString();
            }
        }

        /// <summary>
        /// Aquí se finalizará al hilo secundario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Visual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!object.ReferenceEquals(thread, null))
                if (thread.IsAlive)
                {
                    thread.Abort();
                }
        }

        private void UI_Load(object sender, EventArgs e)
        {
            this.lbl_MensajeAtencion.Visible = false;
            this.rtb_Clientes.Visible = false;
        }
    }
}
