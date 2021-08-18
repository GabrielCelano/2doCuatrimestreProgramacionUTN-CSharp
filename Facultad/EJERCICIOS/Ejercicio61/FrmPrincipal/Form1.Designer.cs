
namespace FrmPrincipal
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.rtbPersonas = new System.Windows.Forms.RichTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLeerPorId = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.grpBuscarPorId = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.grpBuscarPorId.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(144, 250);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(126, 62);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // rtbPersonas
            // 
            this.rtbPersonas.Location = new System.Drawing.Point(523, 12);
            this.rtbPersonas.Name = "rtbPersonas";
            this.rtbPersonas.Size = new System.Drawing.Size(265, 300);
            this.rtbPersonas.TabIndex = 1;
            this.rtbPersonas.Text = "";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(37, 77);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 70);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(124, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 62);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLeerPorId
            // 
            this.btnLeerPorId.Location = new System.Drawing.Point(6, 79);
            this.btnLeerPorId.Name = "btnLeerPorId";
            this.btnLeerPorId.Size = new System.Drawing.Size(110, 31);
            this.btnLeerPorId.TabIndex = 7;
            this.btnLeerPorId.Text = "Buscar";
            this.btnLeerPorId.UseVisualStyleBackColor = true;
            this.btnLeerPorId.Click += new System.EventHandler(this.btnLeerPorId_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(19, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID:";
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(87, 31);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(102, 20);
            this.nudId.TabIndex = 9;
            // 
            // grpBuscarPorId
            // 
            this.grpBuscarPorId.Controls.Add(this.btnBorrar);
            this.grpBuscarPorId.Controls.Add(this.btnModificar);
            this.grpBuscarPorId.Controls.Add(this.lblID);
            this.grpBuscarPorId.Controls.Add(this.nudId);
            this.grpBuscarPorId.Controls.Add(this.btnLeerPorId);
            this.grpBuscarPorId.Location = new System.Drawing.Point(273, 24);
            this.grpBuscarPorId.Name = "grpBuscarPorId";
            this.grpBuscarPorId.Size = new System.Drawing.Size(220, 219);
            this.grpBuscarPorId.TabIndex = 10;
            this.grpBuscarPorId.TabStop = false;
            this.grpBuscarPorId.Text = "Por ID";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(6, 126);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 31);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(6, 174);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 31);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.grpBuscarPorId);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rtbPersonas);
            this.Controls.Add(this.btnLeer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.grpBuscarPorId.ResumeLayout(false);
            this.grpBuscarPorId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.RichTextBox rtbPersonas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLeerPorId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.GroupBox grpBuscarPorId;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

