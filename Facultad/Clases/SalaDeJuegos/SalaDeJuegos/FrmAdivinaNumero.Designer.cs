
namespace SalaDeJuegos
{
    partial class FrmAdivinaNumero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumeroIngresado = new System.Windows.Forms.TextBox();
            this.btnMostrarRandom = new System.Windows.Forms.Button();
            this.chkIntentos = new System.Windows.Forms.CheckBox();
            this.grpNivel = new System.Windows.Forms.GroupBox();
            this.rdo20 = new System.Windows.Forms.RadioButton();
            this.rdo10 = new System.Windows.Forms.RadioButton();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.grpNivel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumeroIngresado
            // 
            this.txtNumeroIngresado.Location = new System.Drawing.Point(13, 190);
            this.txtNumeroIngresado.Name = "txtNumeroIngresado";
            this.txtNumeroIngresado.Size = new System.Drawing.Size(195, 20);
            this.txtNumeroIngresado.TabIndex = 0;
            // 
            // btnMostrarRandom
            // 
            this.btnMostrarRandom.Location = new System.Drawing.Point(120, 230);
            this.btnMostrarRandom.Name = "btnMostrarRandom";
            this.btnMostrarRandom.Size = new System.Drawing.Size(88, 30);
            this.btnMostrarRandom.TabIndex = 1;
            this.btnMostrarRandom.Text = "Verificar";
            this.btnMostrarRandom.UseVisualStyleBackColor = true;
            this.btnMostrarRandom.Visible = false;
            this.btnMostrarRandom.Click += new System.EventHandler(this.btnMostrarRandom_Click);
            // 
            // chkIntentos
            // 
            this.chkIntentos.AutoSize = true;
            this.chkIntentos.Checked = true;
            this.chkIntentos.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkIntentos.Location = new System.Drawing.Point(13, 25);
            this.chkIntentos.Name = "chkIntentos";
            this.chkIntentos.Size = new System.Drawing.Size(106, 17);
            this.chkIntentos.TabIndex = 2;
            this.chkIntentos.Text = "Contar 5 intentos";
            this.chkIntentos.UseVisualStyleBackColor = true;
            // 
            // grpNivel
            // 
            this.grpNivel.Controls.Add(this.rdo20);
            this.grpNivel.Controls.Add(this.rdo10);
            this.grpNivel.Controls.Add(this.rdo5);
            this.grpNivel.Location = new System.Drawing.Point(13, 60);
            this.grpNivel.Name = "grpNivel";
            this.grpNivel.Size = new System.Drawing.Size(195, 124);
            this.grpNivel.TabIndex = 3;
            this.grpNivel.TabStop = false;
            this.grpNivel.Text = "Nivel";
            this.grpNivel.Enter += new System.EventHandler(this.grpNivel_Enter);
            // 
            // rdo20
            // 
            this.rdo20.AutoSize = true;
            this.rdo20.Location = new System.Drawing.Point(19, 87);
            this.rdo20.Name = "rdo20";
            this.rdo20.Size = new System.Drawing.Size(37, 17);
            this.rdo20.TabIndex = 2;
            this.rdo20.TabStop = true;
            this.rdo20.Text = "20";
            this.rdo20.UseVisualStyleBackColor = true;
            // 
            // rdo10
            // 
            this.rdo10.AutoSize = true;
            this.rdo10.Location = new System.Drawing.Point(19, 53);
            this.rdo10.Name = "rdo10";
            this.rdo10.Size = new System.Drawing.Size(37, 17);
            this.rdo10.TabIndex = 1;
            this.rdo10.TabStop = true;
            this.rdo10.Text = "10";
            this.rdo10.UseVisualStyleBackColor = true;
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(19, 20);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(31, 17);
            this.rdo5.TabIndex = 0;
            this.rdo5.TabStop = true;
            this.rdo5.Text = "5";
            this.rdo5.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(13, 231);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(93, 29);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // FrmAdivinaNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 272);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.grpNivel);
            this.Controls.Add(this.chkIntentos);
            this.Controls.Add(this.btnMostrarRandom);
            this.Controls.Add(this.txtNumeroIngresado);
            this.Name = "FrmAdivinaNumero";
            this.Text = "FrmAdivinaNumero";
            this.Load += new System.EventHandler(this.FrmAdivinaNumero_Load);
            this.grpNivel.ResumeLayout(false);
            this.grpNivel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroIngresado;
        private System.Windows.Forms.Button btnMostrarRandom;
        private System.Windows.Forms.CheckBox chkIntentos;
        private System.Windows.Forms.GroupBox grpNivel;
        private System.Windows.Forms.RadioButton rdo20;
        private System.Windows.Forms.RadioButton rdo10;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.Button btnIniciar;
    }
}