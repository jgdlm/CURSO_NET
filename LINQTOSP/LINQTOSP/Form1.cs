using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQTOSP
{
    public partial class Form1 : Form
    {
        //Creo el objeto de la base de Datos para acceder SQL
        DataClasses1DataContext CLienteLinq = new DataClasses1DataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CLienteLinq.insertarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.ListarClientes();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CLienteLinq.Modificarcliente(TxtNombre.Text, TxtApellido1.Text, TxtApellido2.Text, TxtTelefono.Text);
            this.ListarClientes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CLienteLinq.EliminarCliente(TxtNombre.Text);
            this.ListarClientes();
        }


        void ListarClientes() 
        {
            GridDatos.DataSource = CLienteLinq.ListarClientes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListarClientes();
        }

        private void GridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridDatos.DataSource = CLienteLinq.Buscarcliente(TxtBuscar.Text);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido1.Text = "";
            TxtApellido2.Text = "";
            TxtTelefono.Text = "";
            TxtBuscar.Text = "";
        }
    }
}
