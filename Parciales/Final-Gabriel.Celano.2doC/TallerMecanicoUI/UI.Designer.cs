
namespace TallerMecanicoUI
{
    partial class UI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_ClientesAtendidos = new System.Windows.Forms.Label();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.rtb_Clientes = new System.Windows.Forms.RichTextBox();
            this.lbl_MensajeAtencion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_ClientesAtendidos
            // 
            this.lb_ClientesAtendidos.AutoSize = true;
            this.lb_ClientesAtendidos.Location = new System.Drawing.Point(71, 54);
            this.lb_ClientesAtendidos.Name = "lb_ClientesAtendidos";
            this.lb_ClientesAtendidos.Size = new System.Drawing.Size(181, 13);
            this.lb_ClientesAtendidos.TabIndex = 1;
            this.lb_ClientesAtendidos.Text = "Aun no hemos comenzado a atender";
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(12, 12);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(290, 23);
            this.btn_Iniciar.TabIndex = 2;
            this.btn_Iniciar.Text = "Iniciar Atencion";
            this.btn_Iniciar.UseVisualStyleBackColor = true;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // rtb_Clientes
            // 
            this.rtb_Clientes.Location = new System.Drawing.Point(73, 111);
            this.rtb_Clientes.Name = "rtb_Clientes";
            this.rtb_Clientes.Size = new System.Drawing.Size(179, 24);
            this.rtb_Clientes.TabIndex = 3;
            this.rtb_Clientes.Text = "";
            // 
            // lbl_MensajeAtencion
            // 
            this.lbl_MensajeAtencion.AutoSize = true;
            this.lbl_MensajeAtencion.Location = new System.Drawing.Point(71, 95);
            this.lbl_MensajeAtencion.Name = "lbl_MensajeAtencion";
            this.lbl_MensajeAtencion.Size = new System.Drawing.Size(115, 13);
            this.lbl_MensajeAtencion.TabIndex = 4;
            this.lbl_MensajeAtencion.Text = "Estamos atendiendo a:";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(320, 160);
            this.Controls.Add(this.lbl_MensajeAtencion);
            this.Controls.Add(this.rtb_Clientes);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.lb_ClientesAtendidos);
            this.Name = "UI";
            this.Text = "Taller UTN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Visual_FormClosing);
            this.Load += new System.EventHandler(this.UI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_ClientesAtendidos;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.RichTextBox rtb_Clientes;
        private System.Windows.Forms.Label lbl_MensajeAtencion;
    }
}

