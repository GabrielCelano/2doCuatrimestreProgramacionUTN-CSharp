
namespace VistaForm
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
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.grpDatosCurso = new System.Windows.Forms.GroupBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnMostrarCurso = new System.Windows.Forms.Button();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.txtDocumentoProfesor = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.gpbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.txtLegajoAlumno = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.cmbDivisionAlumno = new System.Windows.Forms.ComboBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.gpbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(12, 330);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(675, 219);
            this.rtbDatos.TabIndex = 0;
            this.rtbDatos.Text = "";
            // 
            // grpDatosCurso
            // 
            this.grpDatosCurso.Controls.Add(this.dtpFechaIngreso);
            this.grpDatosCurso.Controls.Add(this.btnMostrarCurso);
            this.grpDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.grpDatosCurso.Controls.Add(this.btnCrearCurso);
            this.grpDatosCurso.Controls.Add(this.txtDocumentoProfesor);
            this.grpDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.grpDatosCurso.Controls.Add(this.txtNombreProfe);
            this.grpDatosCurso.Controls.Add(this.lblFechaIngreso);
            this.grpDatosCurso.Controls.Add(this.lblDni);
            this.grpDatosCurso.Controls.Add(this.lblApellido);
            this.grpDatosCurso.Controls.Add(this.lblNombre);
            this.grpDatosCurso.Controls.Add(this.lblDivision);
            this.grpDatosCurso.Controls.Add(this.lblAnio);
            this.grpDatosCurso.Controls.Add(this.nudAnioCurso);
            this.grpDatosCurso.Location = new System.Drawing.Point(13, 28);
            this.grpDatosCurso.Name = "grpDatosCurso";
            this.grpDatosCurso.Size = new System.Drawing.Size(331, 296);
            this.grpDatosCurso.TabIndex = 1;
            this.grpDatosCurso.TabStop = false;
            this.grpDatosCurso.Text = "Datos Curso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(96, 171);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(210, 20);
            this.dtpFechaIngreso.TabIndex = 12;
            // 
            // btnMostrarCurso
            // 
            this.btnMostrarCurso.Location = new System.Drawing.Point(186, 225);
            this.btnMostrarCurso.Name = "btnMostrarCurso";
            this.btnMostrarCurso.Size = new System.Drawing.Size(139, 65);
            this.btnMostrarCurso.TabIndex = 3;
            this.btnMostrarCurso.Text = "Mostrar";
            this.btnMostrarCurso.UseVisualStyleBackColor = true;
            this.btnMostrarCurso.Click += new System.EventHandler(this.btnMostrarCurso_Click);
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(96, 55);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionCurso.TabIndex = 11;
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(6, 225);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(139, 65);
            this.btnCrearCurso.TabIndex = 2;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // txtDocumentoProfesor
            // 
            this.txtDocumentoProfesor.Location = new System.Drawing.Point(96, 139);
            this.txtDocumentoProfesor.Name = "txtDocumentoProfesor";
            this.txtDocumentoProfesor.Size = new System.Drawing.Size(210, 20);
            this.txtDocumentoProfesor.TabIndex = 10;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(96, 115);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(210, 20);
            this.txtApellidoProfe.TabIndex = 9;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(96, 90);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(210, 20);
            this.txtNombreProfe.TabIndex = 8;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(21, 171);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblFechaIngreso.TabIndex = 6;
            this.lblFechaIngreso.Text = "Ingreso";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(21, 146);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(21, 118);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(21, 58);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 2;
            this.lblDivision.Text = "Division";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(21, 26);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 1;
            this.lblAnio.Text = "Año";
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(96, 24);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(121, 20);
            this.nudAnioCurso.TabIndex = 0;
            this.nudAnioCurso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gpbDatosAlumno
            // 
            this.gpbDatosAlumno.Controls.Add(this.txtLegajoAlumno);
            this.gpbDatosAlumno.Controls.Add(this.txtApellidoAlumno);
            this.gpbDatosAlumno.Controls.Add(this.txtNombreAlumno);
            this.gpbDatosAlumno.Controls.Add(this.cmbDivisionAlumno);
            this.gpbDatosAlumno.Controls.Add(this.nudAnio);
            this.gpbDatosAlumno.Controls.Add(this.btnAgregarAlumno);
            this.gpbDatosAlumno.Controls.Add(this.label5);
            this.gpbDatosAlumno.Controls.Add(this.label4);
            this.gpbDatosAlumno.Controls.Add(this.lblLegajo);
            this.gpbDatosAlumno.Controls.Add(this.label2);
            this.gpbDatosAlumno.Controls.Add(this.label1);
            this.gpbDatosAlumno.Location = new System.Drawing.Point(364, 31);
            this.gpbDatosAlumno.Name = "gpbDatosAlumno";
            this.gpbDatosAlumno.Size = new System.Drawing.Size(323, 262);
            this.gpbDatosAlumno.TabIndex = 4;
            this.gpbDatosAlumno.TabStop = false;
            this.gpbDatosAlumno.Text = "Datos Alumno";
            // 
            // txtLegajoAlumno
            // 
            this.txtLegajoAlumno.Location = new System.Drawing.Point(101, 84);
            this.txtLegajoAlumno.Name = "txtLegajoAlumno";
            this.txtLegajoAlumno.Size = new System.Drawing.Size(210, 20);
            this.txtLegajoAlumno.TabIndex = 15;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(101, 57);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(210, 20);
            this.txtApellidoAlumno.TabIndex = 14;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(101, 25);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(210, 20);
            this.txtNombreAlumno.TabIndex = 13;
            // 
            // cmbDivisionAlumno
            // 
            this.cmbDivisionAlumno.FormattingEnabled = true;
            this.cmbDivisionAlumno.Location = new System.Drawing.Point(101, 140);
            this.cmbDivisionAlumno.Name = "cmbDivisionAlumno";
            this.cmbDivisionAlumno.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionAlumno.TabIndex = 13;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(101, 113);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(121, 20);
            this.nudAnio.TabIndex = 13;
            this.nudAnio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(92, 181);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(139, 65);
            this.btnAgregarAlumno.TabIndex = 13;
            this.btnAgregarAlumno.Text = "Agregar";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Division";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Año";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(22, 87);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 13;
            this.lblLegajo.Text = "Legajo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 561);
            this.Controls.Add(this.gpbDatosAlumno);
            this.Controls.Add(this.grpDatosCurso);
            this.Controls.Add(this.rtbDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDatosCurso.ResumeLayout(false);
            this.grpDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.gpbDatosAlumno.ResumeLayout(false);
            this.gpbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.GroupBox grpDatosCurso;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnMostrarCurso;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.TextBox txtDocumentoProfesor;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.GroupBox gpbDatosAlumno;
        private System.Windows.Forms.TextBox txtLegajoAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.ComboBox cmbDivisionAlumno;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

