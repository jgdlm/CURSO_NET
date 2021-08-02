
namespace FORMULARIOLINQHOSPITALSQL
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
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.BtnBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.BtnAlta = new System.Windows.Forms.Button();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnModif = new System.Windows.Forms.Button();
            this.checkBoxEstadoCivil = new System.Windows.Forms.CheckBox();
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.TxtTotalRegistros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(24, 26);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(100, 20);
            this.TxtBusca.TabIndex = 0;
            // 
            // BtnBusca
            // 
            this.BtnBusca.Location = new System.Drawing.Point(158, 22);
            this.BtnBusca.Name = "BtnBusca";
            this.BtnBusca.Size = new System.Drawing.Size(75, 23);
            this.BtnBusca.TabIndex = 1;
            this.BtnBusca.Text = "BUSCAR";
            this.BtnBusca.UseVisualStyleBackColor = true;
            this.BtnBusca.Click += new System.EventHandler(this.BtnBusca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(51, 62);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(56, 95);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(70, 132);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edad:";
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(56, 168);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(100, 20);
            this.TxtEdad.TabIndex = 9;
            // 
            // BtnAlta
            // 
            this.BtnAlta.Location = new System.Drawing.Point(14, 263);
            this.BtnAlta.Name = "BtnAlta";
            this.BtnAlta.Size = new System.Drawing.Size(75, 23);
            this.BtnAlta.TabIndex = 10;
            this.BtnAlta.Text = "Alta";
            this.BtnAlta.UseVisualStyleBackColor = true;
            this.BtnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(14, 304);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(75, 23);
            this.BtnBaja.TabIndex = 11;
            this.BtnBaja.Text = "Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnModif
            // 
            this.BtnModif.Location = new System.Drawing.Point(12, 343);
            this.BtnModif.Name = "BtnModif";
            this.BtnModif.Size = new System.Drawing.Size(75, 23);
            this.BtnModif.TabIndex = 12;
            this.BtnModif.Text = "Modif.";
            this.BtnModif.UseVisualStyleBackColor = true;
            this.BtnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // checkBoxEstadoCivil
            // 
            this.checkBoxEstadoCivil.AutoSize = true;
            this.checkBoxEstadoCivil.Location = new System.Drawing.Point(56, 205);
            this.checkBoxEstadoCivil.Name = "checkBoxEstadoCivil";
            this.checkBoxEstadoCivil.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEstadoCivil.TabIndex = 13;
            this.checkBoxEstadoCivil.Text = "Casado";
            this.checkBoxEstadoCivil.UseVisualStyleBackColor = true;
            this.checkBoxEstadoCivil.CheckedChanged += new System.EventHandler(this.checkBoxEstadoCivil_CheckedChanged);
            // 
            // GridDatos
            // 
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(237, 65);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.Size = new System.Drawing.Size(713, 301);
            this.GridDatos.TabIndex = 14;
            // 
            // TxtTotalRegistros
            // 
            this.TxtTotalRegistros.Location = new System.Drawing.Point(158, 403);
            this.TxtTotalRegistros.Name = "TxtTotalRegistros";
            this.TxtTotalRegistros.Size = new System.Drawing.Size(100, 20);
            this.TxtTotalRegistros.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Número Total de Registros:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTotalRegistros);
            this.Controls.Add(this.GridDatos);
            this.Controls.Add(this.checkBoxEstadoCivil);
            this.Controls.Add(this.BtnModif);
            this.Controls.Add(this.BtnBaja);
            this.Controls.Add(this.BtnAlta);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBusca);
            this.Controls.Add(this.TxtBusca);
            this.Name = "Form1";
            this.Text = "SISTEMA DE GESTION DE HOSPITAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Button BtnBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Button BtnAlta;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnModif;
        private System.Windows.Forms.CheckBox checkBoxEstadoCivil;
        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.TextBox TxtTotalRegistros;
        private System.Windows.Forms.Label label5;
    }
}

