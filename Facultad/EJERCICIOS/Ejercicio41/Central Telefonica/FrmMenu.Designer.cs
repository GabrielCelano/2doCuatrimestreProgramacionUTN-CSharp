
namespace Central_Telefonica
{
    partial class FrmMenu
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
            this.BtnGenerarLlamada = new System.Windows.Forms.Button();
            this.BtnFacturacionTotal = new System.Windows.Forms.Button();
            this.BtnFacturacionLocal = new System.Windows.Forms.Button();
            this.BtnFacturacionProvincial = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenerarLlamada
            // 
            this.BtnGenerarLlamada.Location = new System.Drawing.Point(40, 22);
            this.BtnGenerarLlamada.Name = "BtnGenerarLlamada";
            this.BtnGenerarLlamada.Size = new System.Drawing.Size(216, 52);
            this.BtnGenerarLlamada.TabIndex = 0;
            this.BtnGenerarLlamada.Text = "Generar Llamada";
            this.BtnGenerarLlamada.UseVisualStyleBackColor = true;
            this.BtnGenerarLlamada.Click += new System.EventHandler(this.BtnGenerarLlamada_Click);
            // 
            // BtnFacturacionTotal
            // 
            this.BtnFacturacionTotal.Location = new System.Drawing.Point(40, 94);
            this.BtnFacturacionTotal.Name = "BtnFacturacionTotal";
            this.BtnFacturacionTotal.Size = new System.Drawing.Size(216, 52);
            this.BtnFacturacionTotal.TabIndex = 1;
            this.BtnFacturacionTotal.Text = "Facturación Total";
            this.BtnFacturacionTotal.UseVisualStyleBackColor = true;
            this.BtnFacturacionTotal.Click += new System.EventHandler(this.BtnFacturacionTotal_Click);
            // 
            // BtnFacturacionLocal
            // 
            this.BtnFacturacionLocal.Location = new System.Drawing.Point(40, 164);
            this.BtnFacturacionLocal.Name = "BtnFacturacionLocal";
            this.BtnFacturacionLocal.Size = new System.Drawing.Size(216, 52);
            this.BtnFacturacionLocal.TabIndex = 2;
            this.BtnFacturacionLocal.Text = "Facturación Local";
            this.BtnFacturacionLocal.UseVisualStyleBackColor = true;
            this.BtnFacturacionLocal.Click += new System.EventHandler(this.BtnFacturacionLocal_Click);
            // 
            // BtnFacturacionProvincial
            // 
            this.BtnFacturacionProvincial.Location = new System.Drawing.Point(40, 232);
            this.BtnFacturacionProvincial.Name = "BtnFacturacionProvincial";
            this.BtnFacturacionProvincial.Size = new System.Drawing.Size(216, 52);
            this.BtnFacturacionProvincial.TabIndex = 3;
            this.BtnFacturacionProvincial.Text = "Facturación Provincial";
            this.BtnFacturacionProvincial.UseVisualStyleBackColor = true;
            this.BtnFacturacionProvincial.Click += new System.EventHandler(this.BtnFacturacionProvincial_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(40, 302);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(216, 52);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 374);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnFacturacionProvincial);
            this.Controls.Add(this.BtnFacturacionLocal);
            this.Controls.Add(this.BtnFacturacionTotal);
            this.Controls.Add(this.BtnGenerarLlamada);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerarLlamada;
        private System.Windows.Forms.Button BtnFacturacionTotal;
        private System.Windows.Forms.Button BtnFacturacionLocal;
        private System.Windows.Forms.Button BtnFacturacionProvincial;
        private System.Windows.Forms.Button BtnSalir;
    }
}

