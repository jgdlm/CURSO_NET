using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormBANCOSQL
{
    public partial class Form1 : Form
    {
        //Creo el objeto de la base de Datos para acceder SQL
        DataClasses1DataContext CLIENTELinq = new DataClasses1DataContext();


        //Funcion para listar en grid y que llamo al actualizar
        void ListarClientes()
        {
            DataGridDatos.DataSource = CLIENTELinq.ListarClientes();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListarClientes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            CLIENTELinq.AñadirCliente(TxtIdCliente.Text,TxtNombre.Text,TxtApellidos.Text);
            this.ListarClientes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CLIENTELinq.EliminarCliente(TxtNombre.Text);
            this.ListarClientes();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            CLIENTELinq.ModificarCliente(TxtIdCliente.Text, TxtApellidos.Text, TxtNombre.Text);
            this.ListarClientes();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
