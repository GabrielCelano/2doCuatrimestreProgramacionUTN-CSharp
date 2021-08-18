
namespace Central_Telefonica
{
    partial class FrmLlamador
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
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.grpBoxPanel = new System.Windows.Forms.GroupBox();
            this.BtnNumeral = new System.Windows.Forms.Button();
            this.BtnCero = new System.Windows.Forms.Button();
            this.BtnNueve = new System.Windows.Forms.Button();
            this.BtnOcho = new System.Windows.Forms.Button();
            this.BtnSeis = new System.Windows.Forms.Button();
            this.BtnCinco = new System.Windows.Forms.Button();
            this.BtnTres = new System.Windows.Forms.Button();
            this.BtnDos = new System.Windows.Forms.Button();
            this.BtnAsterisco = new System.Windows.Forms.Button();
            this.BtnSiete = new System.Windows.Forms.Button();
            this.BtnCuatro = new System.Windows.Forms.Button();
            this.BtnUno = new System.Windows.Forms.Button();
            this.BtnLlamar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.grpBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Enabled = false;
            this.txtNroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDestino.Location = new System.Drawing.Point(12, 12);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(372, 31);
            this.txtNroDestino.TabIndex = 0;
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroDestino.TextChanged += new System.EventHandler(this.TxtNroDestino_TextChanged);
            // 
            // grpBoxPanel
            // 
            this.grpBoxPanel.Controls.Add(this.BtnNumeral);
            this.grpBoxPanel.Controls.Add(this.BtnCero);
            this.grpBoxPanel.Controls.Add(this.BtnNueve);
            this.grpBoxPanel.Controls.Add(this.BtnOcho);
            this.grpBoxPanel.Controls.Add(this.BtnSeis);
            this.grpBoxPanel.Controls.Add(this.BtnCinco);
            this.grpBoxPanel.Controls.Add(this.BtnTres);
            this.grpBoxPanel.Controls.Add(this.BtnDos);
            this.grpBoxPanel.Controls.Add(this.BtnAsterisco);
            this.grpBoxPanel.Controls.Add(this.BtnSiete);
            this.grpBoxPanel.Controls.Add(this.BtnCuatro);
            this.grpBoxPanel.Controls.Add(this.BtnUno);
            this.grpBoxPanel.Location = new System.Drawing.Point(12, 64);
            this.grpBoxPanel.Name = "grpBoxPanel";
            this.grpBoxPanel.Size = new System.Drawing.Size(175, 266);
            this.grpBoxPanel.TabIndex = 1;
            this.grpBoxPanel.TabStop = false;
            this.grpBoxPanel.Text = "Panel";
            // 
            // BtnNumeral
            // 
            this.BtnNumeral.Location = new System.Drawing.Point(118, 196);
            this.BtnNumeral.Name = "BtnNumeral";
            this.BtnNumeral.Size = new System.Drawing.Size(50, 53);
            this.BtnNumeral.TabIndex = 20;
            this.BtnNumeral.Text = "#";
            this.BtnNumeral.UseVisualStyleBackColor = true;
            this.BtnNumeral.Click += new System.EventHandler(this.BtnNumeral_Click);
            // 
            // BtnCero
            // 
            this.BtnCero.Location = new System.Drawing.Point(62, 196);
            this.BtnCero.Name = "BtnCero";
            this.BtnCero.Size = new System.Drawing.Size(50, 53);
            this.BtnCero.TabIndex = 19;
            this.BtnCero.Text = "0";
            this.BtnCero.UseVisualStyleBackColor = true;
            this.BtnCero.Click += new System.EventHandler(this.BtnCero_Click);
            // 
            // BtnNueve
            // 
            this.BtnNueve.Location = new System.Drawing.Point(118, 137);
            this.BtnNueve.Name = "BtnNueve";
            this.BtnNueve.Size = new System.Drawing.Size(50, 53);
            this.BtnNueve.TabIndex = 18;
            this.BtnNueve.Text = "9";
            this.BtnNueve.UseVisualStyleBackColor = true;
            this.BtnNueve.Click += new System.EventHandler(this.BtnNueve_Click);
            // 
            // BtnOcho
            // 
            this.BtnOcho.Location = new System.Drawing.Point(62, 137);
            this.BtnOcho.Name = "BtnOcho";
            this.BtnOcho.Size = new System.Drawing.Size(50, 53);
            this.BtnOcho.TabIndex = 17;
            this.BtnOcho.Text = "8";
            this.BtnOcho.UseVisualStyleBackColor = true;
            this.BtnOcho.Click += new System.EventHandler(this.BtnOcho_Click);
            // 
            // BtnSeis
            // 
            this.BtnSeis.Location = new System.Drawing.Point(118, 78);
            this.BtnSeis.Name = "BtnSeis";
            this.BtnSeis.Size = new System.Drawing.Size(50, 53);
            this.BtnSeis.TabIndex = 16;
            this.BtnSeis.Text = "6";
            this.BtnSeis.UseVisualStyleBackColor = true;
            this.BtnSeis.Click += new System.EventHandler(this.BtnSeis_Click);
            // 
            // BtnCinco
            // 
            this.BtnCinco.Location = new System.Drawing.Point(62, 78);
            this.BtnCinco.Name = "BtnCinco";
            this.BtnCinco.Size = new System.Drawing.Size(50, 53);
            this.BtnCinco.TabIndex = 15;
            this.BtnCinco.Text = "5";
            this.BtnCinco.UseVisualStyleBackColor = true;
            this.BtnCinco.Click += new System.EventHandler(this.BtnCinco_Click);
            // 
            // BtnTres
            // 
            this.BtnTres.Location = new System.Drawing.Point(118, 19);
            this.BtnTres.Name = "BtnTres";
            this.BtnTres.Size = new System.Drawing.Size(50, 53);
            this.BtnTres.TabIndex = 14;
            this.BtnTres.Text = "3";
            this.BtnTres.UseVisualStyleBackColor = true;
            this.BtnTres.Click += new System.EventHandler(this.BtnTres_Click);
            // 
            // BtnDos
            // 
            this.BtnDos.Location = new System.Drawing.Point(62, 19);
            this.BtnDos.Name = "BtnDos";
            this.BtnDos.Size = new System.Drawing.Size(50, 53);
            this.BtnDos.TabIndex = 13;
            this.BtnDos.Text = "2";
            this.BtnDos.UseVisualStyleBackColor = true;
            this.BtnDos.Click += new System.EventHandler(this.BtnDos_Click);
            // 
            // BtnAsterisco
            // 
            this.BtnAsterisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsterisco.Location = new System.Drawing.Point(6, 196);
            this.BtnAsterisco.Name = "BtnAsterisco";
            this.BtnAsterisco.Size = new System.Drawing.Size(50, 53);
            this.BtnAsterisco.TabIndex = 12;
            this.BtnAsterisco.Text = "*";
            this.BtnAsterisco.UseVisualStyleBackColor = true;
            this.BtnAsterisco.Click += new System.EventHandler(this.BtnAsterisco_Click);
            // 
            // BtnSiete
            // 
            this.BtnSiete.Location = new System.Drawing.Point(6, 137);
            this.BtnSiete.Name = "BtnSiete";
            this.BtnSiete.Size = new System.Drawing.Size(50, 53);
            this.BtnSiete.TabIndex = 11;
            this.BtnSiete.Text = "7";
            this.BtnSiete.UseVisualStyleBackColor = true;
            this.BtnSiete.Click += new System.EventHandler(this.BtnSiete_Click);
            // 
            // BtnCuatro
            // 
            this.BtnCuatro.Location = new System.Drawing.Point(6, 78);
            this.BtnCuatro.Name = "BtnCuatro";
            this.BtnCuatro.Size = new System.Drawing.Size(50, 53);
            this.BtnCuatro.TabIndex = 10;
            this.BtnCuatro.Text = "4";
            this.BtnCuatro.UseVisualStyleBackColor = true;
            this.BtnCuatro.Click += new System.EventHandler(this.BtnCuatro_Click);
            // 
            // BtnUno
            // 
            this.BtnUno.Location = new System.Drawing.Point(6, 19);
            this.BtnUno.Name = "BtnUno";
            this.BtnUno.Size = new System.Drawing.Size(50, 53);
            this.BtnUno.TabIndex = 7;
            this.BtnUno.Text = "1";
            this.BtnUno.UseVisualStyleBackColor = true;
            this.BtnUno.Click += new System.EventHandler(this.BtnUno_Click);
            // 
            // BtnLlamar
            // 
            this.BtnLlamar.Location = new System.Drawing.Point(204, 87);
            this.BtnLlamar.Name = "BtnLlamar";
            this.BtnLlamar.Size = new System.Drawing.Size(180, 49);
            this.BtnLlamar.TabIndex = 2;
            this.BtnLlamar.Text = "Llamar";
            this.BtnLlamar.UseVisualStyleBackColor = true;
            this.BtnLlamar.Click += new System.EventHandler(this.BtnLlamar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(203, 155);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(180, 49);
            this.BtnLimpiar.TabIndex = 3;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroOrigen.Location = new System.Drawing.Point(203, 223);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(179, 26);
            this.txtNroOrigen.TabIndex = 4;
            this.txtNroOrigen.Text = "Nro Origen";
            this.txtNroOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroOrigen_KeyPress);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(203, 267);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(180, 51);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // cmbFranja
            // 
            this.cmbFranja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFranja.Enabled = false;
            this.cmbFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(13, 339);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(371, 32);
            this.cmbFranja.TabIndex = 6;
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 383);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnLlamar);
            this.Controls.Add(this.grpBoxPanel);
            this.Controls.Add(this.txtNroDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.grpBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.GroupBox grpBoxPanel;
        private System.Windows.Forms.Button BtnLlamar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.Button BtnTres;
        private System.Windows.Forms.Button BtnDos;
        private System.Windows.Forms.Button BtnAsterisco;
        private System.Windows.Forms.Button BtnSiete;
        private System.Windows.Forms.Button BtnCuatro;
        private System.Windows.Forms.Button BtnUno;
        private System.Windows.Forms.Button BtnNumeral;
        private System.Windows.Forms.Button BtnCero;
        private System.Windows.Forms.Button BtnNueve;
        private System.Windows.Forms.Button BtnOcho;
        private System.Windows.Forms.Button BtnSeis;
        private System.Windows.Forms.Button BtnCinco;
    }
}