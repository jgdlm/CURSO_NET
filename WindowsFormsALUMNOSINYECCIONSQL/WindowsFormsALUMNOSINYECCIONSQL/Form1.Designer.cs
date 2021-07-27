
namespace WindowsFormsALUMNOSINYECCIONSQL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTurno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEspecialidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxModulo = new System.Windows.Forms.ComboBox();
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxRepetidor = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDNI = new System.Windows.Forms.Button();
            this.BtnCodigo = new System.Windows.Forms.Button();
            this.TextDNI = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.Btnbaja = new System.Windows.Forms.Button();
            this.BtnModificacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(66, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Deshabilitado";
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(66, 55);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(173, 20);
            this.TxtDNI.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(270, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(326, 59);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(173, 20);
            this.TxtNombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turno";
            // 
            // comboBoxTurno
            // 
            this.comboBoxTurno.FormattingEnabled = true;
            this.comboBoxTurno.Items.AddRange(new object[] {
            "Diurno",
            "Nocturno"});
            this.comboBoxTurno.Location = new System.Drawing.Point(66, 93);
            this.comboBoxTurno.Name = "comboBoxTurno";
            this.comboBoxTurno.Size = new System.Drawing.Size(173, 21);
            this.comboBoxTurno.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(280, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxSexo.Location = new System.Drawing.Point(326, 98);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(173, 21);
            this.comboBoxSexo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Especialidad";
            // 
            // comboBoxEspecialidad
            // 
            this.comboBoxEspecialidad.FormattingEnabled = true;
            this.comboBoxEspecialidad.Items.AddRange(new object[] {
            "Todos",
            "COMPUTACIÓN E INFORMÁTICA",
            "CIENCIAS SOCIALES",
            "TECNOLOGIA"});
            this.comboBoxEspecialidad.Location = new System.Drawing.Point(104, 131);
            this.comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            this.comboBoxEspecialidad.Size = new System.Drawing.Size(173, 21);
            this.comboBoxEspecialidad.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(294, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Modulo";
            // 
            // comboBoxModulo
            // 
            this.comboBoxModulo.FormattingEnabled = true;
            this.comboBoxModulo.Items.AddRange(new object[] {
            "Todos",
            "DAM",
            "DAW"});
            this.comboBoxModulo.Location = new System.Drawing.Point(360, 134);
            this.comboBoxModulo.Name = "comboBoxModulo";
            this.comboBoxModulo.Size = new System.Drawing.Size(173, 21);
            this.comboBoxModulo.TabIndex = 13;
            // 
            // GridDatos
            // 
            this.GridDatos.BackgroundColor = System.Drawing.Color.White;
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(36, 205);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.Size = new System.Drawing.Size(853, 150);
            this.GridDatos.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(553, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Repetidor";
            // 
            // checkBoxRepetidor
            // 
            this.checkBoxRepetidor.AutoSize = true;
            this.checkBoxRepetidor.Location = new System.Drawing.Point(622, 142);
            this.checkBoxRepetidor.Name = "checkBoxRepetidor";
            this.checkBoxRepetidor.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRepetidor.TabIndex = 16;
            this.checkBoxRepetidor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnDNI);
            this.groupBox1.Controls.Add(this.BtnCodigo);
            this.groupBox1.Controls.Add(this.TextDNI);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(672, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // BtnDNI
            // 
            this.BtnDNI.BackColor = System.Drawing.Color.DarkGray;
            this.BtnDNI.Location = new System.Drawing.Point(132, 51);
            this.BtnDNI.Name = "BtnDNI";
            this.BtnDNI.Size = new System.Drawing.Size(48, 23);
            this.BtnDNI.TabIndex = 21;
            this.BtnDNI.UseVisualStyleBackColor = false;
            this.BtnDNI.Click += new System.EventHandler(this.BtnDNI_Click);
            // 
            // BtnCodigo
            // 
            this.BtnCodigo.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCodigo.Location = new System.Drawing.Point(132, 15);
            this.BtnCodigo.Name = "BtnCodigo";
            this.BtnCodigo.Size = new System.Drawing.Size(48, 23);
            this.BtnCodigo.TabIndex = 20;
            this.BtnCodigo.UseVisualStyleBackColor = false;
            this.BtnCodigo.Click += new System.EventHandler(this.BtnCodigo_Click);
            // 
            // TextDNI
            // 
            this.TextDNI.Location = new System.Drawing.Point(68, 56);
            this.TextDNI.Name = "TextDNI";
            this.TextDNI.Size = new System.Drawing.Size(48, 20);
            this.TextDNI.TabIndex = 19;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(68, 20);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(48, 20);
            this.TxtCodigo.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "DNI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Código";
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(672, 124);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(62, 49);
            this.BtnAlta.TabIndex = 18;
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // Btnbaja
            // 
            this.Btnbaja.Location = new System.Drawing.Point(750, 124);
            this.Btnbaja.Name = "Btnbaja";
            this.Btnbaja.Size = new System.Drawing.Size(62, 49);
            this.Btnbaja.TabIndex = 19;
            this.Btnbaja.Text = "Baja";
            this.Btnbaja.UseVisualStyleBackColor = true;
            this.Btnbaja.Click += new System.EventHandler(this.Btnbaja_Click);
            // 
            // BtnModificacion
            // 
            this.BtnModificacion.Location = new System.Drawing.Point(827, 124);
            this.BtnModificacion.Name = "BtnModificacion";
            this.BtnModificacion.Size = new System.Drawing.Size(62, 49);
            this.BtnModificacion.TabIndex = 20;
            this.BtnModificacion.Text = "Modificación";
            this.BtnModificacion.UseVisualStyleBackColor = true;
            this.BtnModificacion.Click += new System.EventHandler(this.BtnModificacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.BtnModificacion);
            this.Controls.Add(this.Btnbaja);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxRepetidor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GridDatos);
            this.Controls.Add(this.comboBoxModulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxEspecialidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Listado de Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEspecialidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxModulo;
        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxRepetidor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDNI;
        private System.Windows.Forms.Button BtnCodigo;
        private System.Windows.Forms.TextBox TextDNI;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button Btnbaja;
        private System.Windows.Forms.Button BtnModificacion;
    }
}

