
namespace FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.lblBotellaTipo = new System.Windows.Forms.Label();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.rdoAgua = new System.Windows.Forms.RadioButton();
            this.rdoCerveza = new System.Windows.Forms.RadioButton();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.numericUpDownContenido = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCapacidad = new System.Windows.Forms.NumericUpDown();
            this.barra = new ControlCantina.Barra();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.lblBotellaTipo);
            this.grpBox.Controls.Add(this.cmbBotellaTipo);
            this.grpBox.Controls.Add(this.btnAgregar);
            this.grpBox.Controls.Add(this.lblMarca);
            this.grpBox.Controls.Add(this.txtMarca);
            this.grpBox.Controls.Add(this.rdoAgua);
            this.grpBox.Controls.Add(this.rdoCerveza);
            this.grpBox.Controls.Add(this.lblContenido);
            this.grpBox.Controls.Add(this.lblCapacidad);
            this.grpBox.Controls.Add(this.numericUpDownContenido);
            this.grpBox.Controls.Add(this.numericUpDownCapacidad);
            this.grpBox.Location = new System.Drawing.Point(13, 387);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(550, 99);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            // 
            // lblBotellaTipo
            // 
            this.lblBotellaTipo.AutoSize = true;
            this.lblBotellaTipo.Location = new System.Drawing.Point(359, 11);
            this.lblBotellaTipo.Name = "lblBotellaTipo";
            this.lblBotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lblBotellaTipo.TabIndex = 10;
            this.lblBotellaTipo.Text = "Botella Tipo";
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(362, 27);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(143, 21);
            this.cmbBotellaTipo.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(362, 54);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 39);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(158, 16);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(161, 34);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(159, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // rdoAgua
            // 
            this.rdoAgua.AutoSize = true;
            this.rdoAgua.Location = new System.Drawing.Point(18, 47);
            this.rdoAgua.Name = "rdoAgua";
            this.rdoAgua.Size = new System.Drawing.Size(50, 17);
            this.rdoAgua.TabIndex = 5;
            this.rdoAgua.TabStop = true;
            this.rdoAgua.Text = "Agua";
            this.rdoAgua.UseVisualStyleBackColor = true;
            // 
            // rdoCerveza
            // 
            this.rdoCerveza.AutoSize = true;
            this.rdoCerveza.Location = new System.Drawing.Point(18, 19);
            this.rdoCerveza.Name = "rdoCerveza";
            this.rdoCerveza.Size = new System.Drawing.Size(64, 17);
            this.rdoCerveza.TabIndex = 4;
            this.rdoCerveza.TabStop = true;
            this.rdoCerveza.Text = "Cerveza";
            this.rdoCerveza.UseVisualStyleBackColor = true;
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(247, 57);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(55, 13);
            this.lblContenido.TabIndex = 3;
            this.lblContenido.Text = "Contenido";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(158, 57);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 2;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // numericUpDownContenido
            // 
            this.numericUpDownContenido.Location = new System.Drawing.Point(250, 73);
            this.numericUpDownContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownContenido.Name = "numericUpDownContenido";
            this.numericUpDownContenido.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownContenido.TabIndex = 1;
            this.numericUpDownContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownCapacidad
            // 
            this.numericUpDownCapacidad.Location = new System.Drawing.Point(161, 73);
            this.numericUpDownCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacidad.Name = "numericUpDownCapacidad";
            this.numericUpDownCapacidad.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownCapacidad.TabIndex = 0;
            this.numericUpDownCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(12, 12);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(551, 368);
            this.barra.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 489);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.barra);
            this.Name = "Form1";
            this.Text = "Practica Cantina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlCantina.Barra barra;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.NumericUpDown numericUpDownContenido;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.RadioButton rdoAgua;
        private System.Windows.Forms.RadioButton rdoCerveza;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblBotellaTipo;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.Button btnAgregar;
    }
}

