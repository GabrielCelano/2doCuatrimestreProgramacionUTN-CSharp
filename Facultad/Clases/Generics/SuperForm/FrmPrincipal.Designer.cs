
namespace SuperForm
{
    partial class FrmPrincipal
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.rtbClientes = new System.Windows.Forms.RichTextBox();
            this.rtbProductos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(103, 399);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(215, 24);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(456, 397);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(236, 26);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // rtbClientes
            // 
            this.rtbClientes.Location = new System.Drawing.Point(418, 22);
            this.rtbClientes.Name = "rtbClientes";
            this.rtbClientes.Size = new System.Drawing.Size(347, 364);
            this.rtbClientes.TabIndex = 3;
            this.rtbClientes.Text = "";
            this.rtbClientes.TextChanged += new System.EventHandler(this.rtbClientes_TextChanged);
            // 
            // rtbProductos
            // 
            this.rtbProductos.Location = new System.Drawing.Point(31, 22);
            this.rtbProductos.Name = "rtbProductos";
            this.rtbProductos.Size = new System.Drawing.Size(348, 364);
            this.rtbProductos.TabIndex = 4;
            this.rtbProductos.Text = "";
            // 
            // FrmSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbProductos);
            this.Controls.Add(this.rtbClientes);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnAgregarProducto);
            this.Name = "FrmSuper";
            this.Text = "FrmSuper";
            this.Load += new System.EventHandler(this.FrmSuper_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.RichTextBox rtbClientes;
        private System.Windows.Forms.RichTextBox rtbProductos;
    }
}

