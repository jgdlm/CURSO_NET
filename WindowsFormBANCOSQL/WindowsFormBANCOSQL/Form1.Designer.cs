
namespace WindowsFormBANCOSQL
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DataGridDatos = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.TxtIdCliente = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormBANCOSQL.Properties.Resources.LOGO_ING1;
            this.pictureBox1.Location = new System.Drawing.Point(314, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Items.AddRange(new object[] {
            "IDCLIENTE",
            "APELLIDOS",
            "NOMBRES"});
            this.comboBoxBuscar.Location = new System.Drawing.Point(12, 166);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(195, 27);
            this.comboBoxBuscar.TabIndex = 2;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtBuscar.Location = new System.Drawing.Point(247, 167);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(448, 26);
            this.TxtBuscar.TabIndex = 3;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DataGridDatos
            // 
            this.DataGridDatos.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.DataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDatos.GridColor = System.Drawing.Color.DarkOrange;
            this.DataGridDatos.Location = new System.Drawing.Point(12, 237);
            this.DataGridDatos.Name = "DataGridDatos";
            this.DataGridDatos.Size = new System.Drawing.Size(683, 304);
            this.DataGridDatos.TabIndex = 4;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Orange;
            this.BtnAgregar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnAgregar.Location = new System.Drawing.Point(275, 557);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(110, 34);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Orange;
            this.BtnEliminar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnEliminar.Location = new System.Drawing.Point(412, 557);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(110, 34);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Orange;
            this.BtnModificar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnModificar.Location = new System.Drawing.Point(541, 557);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(121, 34);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // TxtIdCliente
            // 
            this.TxtIdCliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtIdCliente.Location = new System.Drawing.Point(838, 262);
            this.TxtIdCliente.Name = "TxtIdCliente";
            this.TxtIdCliente.Size = new System.Drawing.Size(181, 26);
            this.TxtIdCliente.TabIndex = 9;
            this.TxtIdCliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtNombre.Location = new System.Drawing.Point(838, 303);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(181, 26);
            this.TxtNombre.TabIndex = 10;
            this.TxtNombre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtApellidos.Location = new System.Drawing.Point(838, 346);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(181, 26);
            this.TxtApellidos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(719, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "IDCLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(719, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(719, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "APELLIDOS";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Orange;
            this.BtnBuscar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnBuscar.Location = new System.Drawing.Point(723, 162);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(121, 34);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.ForeColor = System.Drawing.Color.Red;
            this.BtnSalir.Location = new System.Drawing.Point(870, 398);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(134, 39);
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(882, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 658);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdCliente);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.DataGridDatos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Orange;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BANCOSQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DataGridDatos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox TxtIdCliente;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label4;
    }
}

