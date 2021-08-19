using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormREGISTROCLIENTES
{
    public partial class Form1 : Form
    {
        //AÑADIMOS EL CONTEXTO DE ENTIDADES DE CLIENTES
        REPASO_AGOSTOEntities ClientesEntity = new REPASO_AGOSTOEntities();
        public Form1()
        {
            InitializeComponent();
            //LLAMAMOS AL EVENTO DE CARGAR EL GRID
            Cargargrid();
        }
        
        //DEFINIMOS UN EVENTO PARA CARGAR EL GRID
        public void Cargargrid()
        {
            GridDatos.DataSource = ClientesEntity.Clientes.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //BOTÓN REGISTRAR
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try 
            { 
            //CREAMOS UN NUEVO CLIENTE CON LOS CONTENIDOS DE LOS TEXTBOX
            Clientes MisClientes = new Clientes()
            {
                Dni = TxtBuscar.Text,
                Nombre = TxtNombres.Text,
                Apellidos = TxtApellidos.Text,
                Estado_Civil = comboBoxEstadoCivil.Text,
                Telefono = TxtTelefono.Text,
                Email = TxtEmail.Text,
                Fecha_Nacimiento = dateTimePicker1.Value,

            };
            //LLAMAMOS AL CONTEXTO DE ENTIDADES Y AÑADIMOS(REGISTRAMOS) AL OBJETO CLIENTE
            ClientesEntity.Clientes.Add(MisClientes);
            //GUARDAR EL NUEVO REGISTRO EB LA BASE DE DATOS
            ClientesEntity.SaveChanges();
            //REFRESCAMOS EL DATAGRID
            Cargargrid();
            }
            catch
            {
                if (TxtBuscar.Text == "" && TxtNombres.Text=="" && TxtApellidos.Text=="" && comboBoxEstadoCivil.Text=="" && TxtTelefono.Text=="" && TxtEmail.Text=="")
                {
                    MessageBox.Show("No se ha agregado el cliente porque no metiste los datos");
                }
               else 
               {
                    MessageBox.Show("El dni ya existe");
                } 
             }

        }

        //BOTÓN BUSCAR
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
           try
            {
                String TextoDNI = TxtBuscar.Text;
                var BuscarCliente = ClientesEntity.Clientes.Where(c =>
                c.Dni == TextoDNI).Single();
                TxtNombres.Text = BuscarCliente.Nombre;
                TxtApellidos.Text = BuscarCliente.Apellidos;
                comboBoxEstadoCivil.Text = BuscarCliente.Estado_Civil;
                TxtTelefono.Text = BuscarCliente.Telefono;
                TxtEmail.Text = BuscarCliente.Email;
                dateTimePicker1.Text = BuscarCliente.Fecha_Nacimiento.ToString();
            }
            catch 
            {
                MessageBox.Show("No se ha Introducido el Dni para buscar al cliente");
            }

        }

        //BOTÓN ELIMINAR
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //DEFINIMOS UNA VARIABLE QUE GUARDA EL DNI
                String TextoDNI = TxtBuscar.Text;
                //METODO LAMDBA QUE CONSIGUE A UN CLIENTE POR SU DNI
                var deleteCliente = ClientesEntity.Clientes.Where(c =>
                c.Dni == TextoDNI).Single();
                //LLAMAMOS AL CONTEXTO DE ENTIDADES Y ELIMINAMOS AL OBJETO CLIENTE BUSCADO
                ClientesEntity.Clientes.Remove(deleteCliente);
                ClientesEntity.SaveChanges();
                Cargargrid();
            }
            catch
            {
                MessageBox.Show("No se ha Introducido el Dni para Eliminar al cliente");
            }
        }

        //BOTÓN MODIFICAR
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //DEFINIR UNA VARIABLE PARA EL DNI OJO DEBERÍA ESTAR CONTROLADO
                //TODO: (QUEDA PENDIENTE)
                String TextoDNI = TxtBuscar.Text;
                //MEDIANTE METODO LINQ PARA CONSEGUIR UN CLIENTE POR SU DNI
                Clientes MisClientes = (from c in ClientesEntity.Clientes
                                        where c.Dni == TextoDNI
                                        select c).Single();

                //DEFINIMOS LOS ATRIBUTOS DEL OBJETO MisClientes
                //MisClientes.Dni = TxtBuscar.Text;
                MisClientes.Nombre = TxtNombres.Text;
                MisClientes.Apellidos = TxtApellidos.Text;
                MisClientes.Estado_Civil = comboBoxEstadoCivil.Text;
                MisClientes.Telefono = TxtTelefono.Text;
                MisClientes.Email = TxtEmail.Text;
                MisClientes.Fecha_Nacimiento = dateTimePicker1.Value;
                //HACEMOS SALVADO EN LA BASE DE DATOS
                ClientesEntity.SaveChanges();
                Cargargrid();
            }
            catch 
            {
                MessageBox.Show("No se ha Introducido el Dni para Modificar al cliente");
            }
        }

        //BOTÓN CURSOR DE LA IZQUIERDA <|
        private void button1_Click(object sender, EventArgs e)
        {
            
            var BuscarCliente = ClientesEntity.Clientes.First();
            TxtBuscar.Text = BuscarCliente.Dni;
            TxtNombres.Text = BuscarCliente.Nombre;
            TxtApellidos.Text = BuscarCliente.Apellidos;
            comboBoxEstadoCivil.Text = BuscarCliente.Estado_Civil;
            TxtTelefono.Text = BuscarCliente.Telefono;
            TxtEmail.Text = BuscarCliente.Email;
            dateTimePicker1.Text = BuscarCliente.Fecha_Nacimiento.ToString();

        }

        //BOTÓN CURSOR DE LA DERECHA |>
        private void button4_Click(object sender, EventArgs e)
        {

            var BuscarCliente = ClientesEntity.Clientes.ToList().Last();
            TxtBuscar.Text = BuscarCliente.Dni;
            TxtNombres.Text = BuscarCliente.Nombre;
            TxtApellidos.Text = BuscarCliente.Apellidos;
            comboBoxEstadoCivil.Text = BuscarCliente.Estado_Civil;
            TxtTelefono.Text = BuscarCliente.Telefono;
            TxtEmail.Text = BuscarCliente.Email;
            dateTimePicker1.Text = BuscarCliente.Fecha_Nacimiento.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA ANTERIOR
                int anterior = GridDatos.CurrentRow.Index-1;

                //NOS DESPLAZAMOS A LA FILA ANTERIOR
                GridDatos.CurrentCell = GridDatos.Rows[anterior].Cells
                    [GridDatos.CurrentCell.ColumnIndex];

                //AQUI CARGAMOS EN EL TEXTBOX EL DNI
                TxtBuscar.Text = GridDatos.Rows[anterior].Cells[0].Value.ToString();
                TxtNombres.Text = GridDatos.Rows[anterior].Cells[1].Value.ToString();
                TxtApellidos.Text = GridDatos.Rows[anterior].Cells[2].Value.ToString();
                comboBoxEstadoCivil.Text = GridDatos.Rows[anterior].Cells[3].Value.ToString();
                TxtTelefono.Text = GridDatos.Rows[anterior].Cells[4].Value.ToString();
                TxtEmail.Text = GridDatos.Rows[anterior].Cells[5].Value.ToString();
                dateTimePicker1.Text = GridDatos.Rows[anterior].Cells[6].Value.ToString();
            }
            catch 
            { 

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA POSTERIOR
                int posterior = GridDatos.CurrentRow.Index+1;

                //NOS DESPLAZAMOS A LA FILA POSTERIOR
                GridDatos.CurrentCell = GridDatos.Rows[posterior].Cells
                    [GridDatos.CurrentCell.ColumnIndex];

                //AQUI CARGAMOS EN EL TEXTBOX EL DNI
                TxtBuscar.Text = GridDatos.Rows[posterior].Cells[0].Value.ToString();
                TxtNombres.Text = GridDatos.Rows[posterior].Cells[1].Value.ToString();
                TxtApellidos.Text = GridDatos.Rows[posterior].Cells[2].Value.ToString();
                comboBoxEstadoCivil.Text = GridDatos.Rows[posterior].Cells[3].Value.ToString();
                TxtTelefono.Text = GridDatos.Rows[posterior].Cells[4].Value.ToString();
                TxtEmail.Text = GridDatos.Rows[posterior].Cells[5].Value.ToString();
                dateTimePicker1.Text = GridDatos.Rows[posterior].Cells[6].Value.ToString();
            }
            catch
            { 

            }
        }
    }
}
