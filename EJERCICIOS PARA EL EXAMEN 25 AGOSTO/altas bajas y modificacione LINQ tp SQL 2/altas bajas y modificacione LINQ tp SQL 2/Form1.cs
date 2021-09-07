using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace altas_bajas_y_modificacione_LINQ_tp_SQL_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        //dEFINIMOS LA CLASE
        DataClasses1DataContext dbhospital = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        //CON LINQ HACEMOS UNA CONSULTA PARA QUE CARGUE EL GRID CON TODOS LOS USUARIOS
        void CargarGrid()
        {
            var cargarGrid = from u in dbhospital.usuarios select u;
            dataGridView1.DataSource = cargarGrid;
            contar();
        }

        //BOTON PARA BUSCAR UN REGISTRO
        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //COMPRUEBA QUE EL CUADRO DE BÚSQUEDA NO ESTÁ EN BLANCO
                if (txtBuscar.Text != "")
                {
                    //SI NO ESTÁ EN BLANCO. si TENEMOS ALGO INTRODUCIDO. sE LE HACE UN LAMBDA CON LINQ
                    //OBTENEMOS LOS VALORES QUE CONTENGANLA CADENA DE BÚSQUEDA.
                    //LA CADENA BUSCAR CON CONTAINS
                    usuarios Myusuarios = dbhospital.usuarios.Single(u =>
                    u.nombre.Contains(txtBuscar.Text));

                    //CON ESTO CARGAMOS LOS TEXTBOX DE ABAJO PARA PODER MODIFICAR SUS VALORES EN CASO DE PEDIRLO
                    txtId.Text = Myusuarios.id.ToString();
                    txtName.Text = Myusuarios.nombre;
                    txtApellido.Text = Myusuarios.apellido;
                    txtEdad.Text = Myusuarios.edad.ToString();
                    cbCasado.Checked = Myusuarios.casado;

                    //CON LINQ CARGAMOS EL GRID CON EL NOMBRE/CONTENIDO FILTRADO
                    //FILTRADO Y REFRESCAMOS
                    var buscarNombre = from usuarios in dbhospital.usuarios where usuarios.nombre.Contains(txtBuscar.Text) select usuarios;

                    //CARGAMOS EL DATAGRID CON EL NOMBRE FILTRADO Y REFRESCAMOS EL GRID
                    dataGridView1.DataSource = buscarNombre;
                }
                //CARGAMOS TODO EL GRID CON TODOS LOS REGISTROS
                else
                {
                    var cargarGrid = from u in dbhospital.usuarios select u;
                    dataGridView1.DataSource = cargarGrid;
                }
            }
            catch
            {
                //IF VALIDANDO EL TEXTBOX Y CONTROLANDO LAS RUTINAS DE CONSULTA
                MessageBox.Show("No existe");
            }
        }
       

        //BOTON PARA DAR DE ALTA UN REGISTRO NUEVO
        private void btAlta_Click(object sender, EventArgs e)
        {
            //CONTROLA QUE ESTÉN TODOS LOS DATOS INTRODUCIDOS
            try
            {
                //DEFINIMOS UN OBJETO TIPO USUARIO
                usuarios Myusuarios = new usuarios();

                //GUARDAMOS TODOS LOS DATOS DEL USUARIO
                Myusuarios.id = Int32.Parse(txtId.Text);
                Myusuarios.nombre = txtName.Text;
                Myusuarios.apellido = txtApellido.Text;
                Myusuarios.edad = Int32.Parse(txtEdad.Text);
                Myusuarios.casado = cbCasado.Checked;

                //INSERTONSUBMIT LO QUE ES AÑADIR EL REGISTRO EN LA DDBB
                dbhospital.usuarios.InsertOnSubmit(Myusuarios);

                //SUBMITCHANGES HACE EL COMMIT (CONFIRMACIÓN)
                dbhospital.SubmitChanges();

                //CARGAMOS EL GRID Y LLAMAMOS A LA FUNCIÓN DE CONTAR
                CargarGrid();
            }
            catch{

                MessageBox.Show("Faltan datos");
            }

        }


        //BOTON PARA DAR DE BAJA UN REGISTRO NUEVO
        private void btBaja_Click(object sender, EventArgs e)
        {
            try
            {
                //DENTRO DEL TRY CREAMOS UN OBJETO DE TIPO USUARIO
                //CON LAMBDA Y LOS OBTENEMOS DE LA DDBB DONDE COINDIDA EL ID
                usuarios Myusuarios = dbhospital.usuarios.Single(u =>
                u.id == Int32.Parse(txtId.Text));

                //DELETEONSUBMIT LO QUE ES ELIMINAR EL REGISTRO EN LA DDBB
                dbhospital.usuarios.DeleteOnSubmit(Myusuarios);


                //SUBMITCHANGES HACE EL COMMIT (CONFIRMACIÓN)
                dbhospital.SubmitChanges();

                //CARGAMOS EL GRID
                CargarGrid();
            }
            catch
            {
                if (txtBuscar.Text == "") MessageBox.Show("INTRODUCE EL ID A ELIMINAR");
            }

        }


        //BOTON PARA MODIFICAR UN REGISTRO
        private void btMod_Click(object sender, EventArgs e)
        {
            //TRY PARA PROBAR QUE TODOS LOS CAMPOS ESTÁN RELLENADOS
            //Y EL ID EXISTE
            try
            {
                //LAMBDA PARA SACAR EL REGISTRO BUSCADO
                usuarios Myusuarios = dbhospital.usuarios.Single(u =>
                u.id == Int32.Parse(txtId.Text));
                Myusuarios.nombre = txtName.Text;
                Myusuarios.apellido = txtApellido.Text;
                Myusuarios.edad = Int32.Parse(txtEdad.Text);
                Myusuarios.casado = cbCasado.Checked;

                //SUBMITCHANGES HACE EL COMMIT (CONFIRMACIÓN)
                //ACTUALIZANDO LOS DATOS
                dbhospital.SubmitChanges();
                
                //RECARGA EL GRID Y RECUENTA
                CargarGrid();
            }
            catch
            {
                if (txtId.Text == "" || txtName.Text == "" || txtEdad.Text == "" || txtId.Text == "" || txtEdad.Text == "") 
                    MessageBox.Show("Faltan datos");
            }
            }


        //CONTAR EL NUMERO DE REGISTROS DEL GRID
        void contar()
        {
            //CON LINQ CUENTA EL NUMERO DE REGISTROS Y LO PONE EN UN LABEL
            var ContarLabel = (from u in
                              dbhospital.usuarios
                               select u.id).Count();
            lbContar.Text = "Existen " + ContarLabel.ToString() + " registros";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
