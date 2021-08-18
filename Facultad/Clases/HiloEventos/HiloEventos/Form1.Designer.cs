
namespace HiloEventos
{
    partial class Form1
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
            this.rtbArchivo = new System.Windows.Forms.RichTextBox();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbArchivo
            // 
            this.rtbArchivo.Location = new System.Drawing.Point(13, 13);
            this.rtbArchivo.Name = "rtbArchivo";
            this.rtbArchivo.Size = new System.Drawing.Size(722, 330);
            this.rtbArchivo.TabIndex = 0;
            this.rtbArchivo.Text = "";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(13, 349);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(113, 44);
            this.btnDescargar.TabIndex = 1;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 405);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.rtbArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbArchivo;
        private System.Windows.Forms.Button btnDescargar;
    }
}

