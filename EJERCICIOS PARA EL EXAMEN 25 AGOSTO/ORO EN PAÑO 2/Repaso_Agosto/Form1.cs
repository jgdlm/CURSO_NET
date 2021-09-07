using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_Agosto
{
    public partial class Form1 : Form
    {
        //AÑADIMOS EL CONTEXTO/MODELO DE ENTIDADES DE CLIENTES
        REPASO_AGOSTOEntities2 ClienteEntity = new REPASO_AGOSTOEntities2();
        public Form1()
        {
            InitializeComponent();
            //INVOCAMOS AL EVENTO DE CARGARGRID AL CARGAR EL FORMULARIO
            CargarGrid();
        }

        //DEFINIMOS UN EVENTO PARA CARGAR EL GRID
        public void CargarGrid()
        {
            dataGridView.DataSource = ClienteEntity.Clientes.ToList();
            
            //TAMBIÉN PODEMOS SEGUIR UTILIZANDO LINQ
            //dataGridView.DataSource = from cliente in 
            //ClienteEntity.Clientes select cliente;
        }


        //BOTÓN PARA AGREGAR REGISTRO
        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                //CREAMOS UN NUEVO CLIENTE CON LOS CONTENIDOS DE LOS TEXTBOX
                Clientes Misclientes = new Clientes() //CLIENTE ES LA TABLA DE SQL
                {
                    Dni = txtDNI.Text,
                    Nombre = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Estado_Civil = cbEstado.Text,
                    Telefono = txtTlfno.Text,
                    Email = txtEmail.Text,
                    Fecha_Nacimiento = dtpFecha.Value,
                };

                //LLAMAMOS AL CONTEXTO DE ENTIDADES: ENTITY CONTEXT. Y AÑADIMOS AL OBJETO CLIENTE
                ClienteEntity.Clientes.Add(Misclientes);

                //GUARDAR EL NUEVO REGISTRO EN LA BASE DE DATOS
                //LA SENTENCIA SAVECHANGES ES GLOBAL TANTO 
                //PARA CLASES TIPO LINQ COMO PARA ENTIDADES
                ClienteEntity.SaveChanges();
            }

            //MOSTRAR MENSAJE MAS CONCRETO DE QUE DATO FALTA
            catch
            {
                //PUEDE QUE FALTE UN CAMPO POR CUBRIR
                if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "" || cbEstado.Text == "" || txtTlfno.Text == "" || txtEmail.Text == "" || dtpFecha.Text == "")
                {
                    MessageBox.Show("Falta algún campos por cubrir");
                } 
                else 
                {
                    MessageBox.Show("El DNI está duplicado");
                }
            }

            //REFRESCAMOS DATAGRID
           CargarGrid();
        }


        //BOTON BUSCAR REGISTRO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
           String TextoDNI = txtDNI.Text;
           //MÉTODO LAMBDA CONSIGUE A UN CLIENTE POR SU DNI
           //Y LO VUELCA A UNA LISTA DE REGISTROS
           var BuscarCliente = ClienteEntity.Clientes.Where(c => c.Dni == TextoDNI).Single();
           
            //MÉTODO LINQ EQUIVALENTE QUE DEVUELVE UN SOLO REGISTRO OJO
            //Clientes MyCliente = (from cliente in ClienteEntity.Clientes 
            //where cliente.Dni == TextoDNI select cliente).Single();

            txtNombre.Text= BuscarCliente.Nombre;
            txtApellidos.Text = BuscarCliente.Apellidos;
            cbEstado.Text = BuscarCliente.Estado_Civil;
            txtTlfno.Text = BuscarCliente.Telefono;
            txtEmail.Text = BuscarCliente.Email;
            dtpFecha.Text = BuscarCliente.Fecha_Nacimiento.ToString();
        }


        //BOTON ELIMINAR REGISTRO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //DEFINIMOS UNA VARIABLE QUE GUARDA EL DNI
            String TextoDNI = txtDNI.Text;
            //MÉTODO LAMBDA CONSIGUE A UN CLIENTE POR SU DNI
            var deleteCliente = ClienteEntity.Clientes.Where(c => c.Dni == TextoDNI).Single();

            //MÉTODO LINQ PARA CONSEGUIR UN CLIENTE POR DNI. 
            //TANTO EL LAMBDA COMO EL LINQ INDISTINTAMENTE. OBTENEMOS LO MISMO.
            //Cliente MyCliente = (from cliente in ClienteEntity.Cliente where cliente.DNI == TextoDNI select cliente).Single();

            //BORRAMOS AL CLIENTE CUYO DNI CORRESPONDE CON EL SELECCIONADO
            ClienteEntity.Clientes.Remove(deleteCliente);

            //PARA CONFIRMAR LOS CAMBIOS EN DDBB
            ClienteEntity.SaveChanges();

            //REFRESCAMOS DATAGRID
            CargarGrid();
        }

        //BOTON MODIFICAR REGISTRO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //DEFINIMOS UNA VARIABLE QUE GUARDA EL DNI QUE OJO DEBERÍA ESTAR CONTROLADO
            if (txtDNI.Text == "") MessageBox.Show("Tienes que introducir un DNI");
            else
            {
                String TextoDNI = txtDNI.Text;

                //MÉTODO LAMBDA CON LINQ DENTRO CONSIGUE/BUSCA A UN CLIENTE POR SU DNI
                Clientes MyCliente = (from cliente in ClienteEntity.Clientes where cliente.Dni == TextoDNI select cliente).Single();

                //DEFINIMOS LOS ATRIBUTOS DEL OBJETO MyCLIENTE
                //EL DNI NO SE MODIFICA
                //MyCliente.DNI = txtDNI.Text;
                MyCliente.Nombre = txtNombre.Text;
                MyCliente.Apellidos = txtApellidos.Text;
                MyCliente.Estado_Civil = cbEstado.Text;
                MyCliente.Telefono = txtTlfno.Text;
                MyCliente.Email = txtEmail.Text;
                MyCliente.Fecha_Nacimiento = dtpFecha.Value;

                //HACEMOS UN SALVADO EN LA BASE DE DATOS
                ClienteEntity.SaveChanges();

                //REFRESCAMOS DATAGRID
                CargarGrid();
            }
        }


        //BOTON PARA IR AL PRIMER REGISTRO ----------------NADA
        private void btnInicio_Click(object sender, EventArgs e)
        {
             //MÉTODO LAMBDA CONSIGUE A UN CLIENTE POR SU DNI
            var BuscarCliente = ClienteEntity.Clientes.First(); //eliminamos el where(la condición no es necesaria porque queremos el primer registrado)

            txtDNI.Text = BuscarCliente.Dni;
            txtNombre.Text = BuscarCliente.Nombre;
            txtApellidos.Text = BuscarCliente.Apellidos;
            cbEstado.Text = BuscarCliente.Estado_Civil;
            txtTlfno.Text = BuscarCliente.Telefono;
            txtEmail.Text = BuscarCliente.Email;
            dtpFecha.Text = BuscarCliente.Fecha_Nacimiento.ToString();
        }

        //BOTON PARA IR AL ULTIMO REGISTRO ----------------NADA
        private void button1_Click(object sender, EventArgs e)
        {
            //MÉTODO LAMBDA CONSIGUE A UN CLIENTE POR SU DNI
            var BuscarCliente = ClienteEntity.Clientes.ToList().Last(); //eliminamos el where(la condición no es necesaria porque queremos el último registrado)

            txtDNI.Text = BuscarCliente.Dni;
            txtNombre.Text = BuscarCliente.Nombre;
            txtApellidos.Text = BuscarCliente.Apellidos;
            cbEstado.Text = BuscarCliente.Estado_Civil;
            txtTlfno.Text = BuscarCliente.Telefono;
            txtEmail.Text = BuscarCliente.Email;
            dtpFecha.Text = BuscarCliente.Fecha_Nacimiento.ToString();
        }

        //BOTON RETROCEDER REGISTRO ----------------NADA
        private void btnAtras_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA ANTERIOR
                int anterior = dataGridView.CurrentRow.Index - 1;

            //NOS DESPLAZAMOS a la fila anterior
            dataGridView.CurrentCell = dataGridView.Rows[anterior].Cells[dataGridView.CurrentCell.ColumnIndex];

            //AQUÍ CARGAMOS EN EL TEXTBOX EL DNI
            txtDNI.Text = dataGridView.Rows[anterior].Cells[0].Value.ToString();
            
            txtNombre.Text = dataGridView.Rows[anterior].Cells[1].Value.ToString();
            txtApellidos.Text = dataGridView.Rows[anterior].Cells[2].Value.ToString();
            cbEstado.Text = dataGridView.Rows[anterior].Cells[3].Value.ToString();
            txtTlfno.Text = dataGridView.Rows[anterior].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView.Rows[anterior].Cells[5].Value.ToString();
            dtpFecha.Text = dataGridView.Rows[anterior].Cells[6].Value.ToString();
            }
            catch { }
        }

        //BOTON AVANZAR REGISTRO ----------------NADA
        private void btnAlante_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA ANTERIOR
                int anterior = dataGridView.CurrentRow.Index + 1;

                //NOS DESPLAZAMOS a la fila anterior
                dataGridView.CurrentCell = dataGridView.Rows[anterior].Cells[dataGridView.CurrentCell.ColumnIndex];

                //AQUÍ CARGAMOS EN EL TEXTBOX EL DNI
                txtDNI.Text = dataGridView.Rows[anterior].Cells[0].Value.ToString();

                txtNombre.Text = dataGridView.Rows[anterior].Cells[1].Value.ToString();
                txtApellidos.Text = dataGridView.Rows[anterior].Cells[2].Value.ToString();
                cbEstado.Text = dataGridView.Rows[anterior].Cells[3].Value.ToString();
                txtTlfno.Text = dataGridView.Rows[anterior].Cells[4].Value.ToString();
                txtEmail.Text = dataGridView.Rows[anterior].Cells[5].Value.ToString();
                dtpFecha.Text = dataGridView.Rows[anterior].Cells[6].Value.ToString();
            }
            catch { }
        }
    }
}