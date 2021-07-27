using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Insertar este using


namespace WindowsFormsALUMNOSINYECCIONSQL
{
    public partial class Form1 : Form
    {
        //Defines la conexión a la base de datos sql server (INYECCION SQL)
          private SqlConnection conexion = new SqlConnection("server = ASATA407\\SQLEXPRESSJORGE; Initial Catalog = ALUMNOSSQL; Persist Security Info=true;Pwd=1234;User ID = sa");

        //Creo el objeto de la base de Datos para acceder SQL (LINQ SQL, PROCEDIMIENTOS ALMACENADOS)
        DataClasses1DataContext AlumnoLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }
        void ListarAlumnos()
        {
            GridDatos.DataSource = AlumnoLinq.ListarAlumnos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ListarAlumnos();
        }

        private void BtnCodigo_Click(object sender, EventArgs e)
        {
           
            GridDatos.DataSource = AlumnoLinq.buscaCodigo(int.Parse(TxtCodigo.Text));
        }

        private void BtnDNI_Click(object sender, EventArgs e)
        {
 
            GridDatos.DataSource = AlumnoLinq.buscaDni(TextDNI.Text);
        }

        //DAR DE ALTA UN ALUMNO
        private void BtnAlta_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string dni = TxtDNI.Text;
            string nombre = TxtNombre.Text;
            string turno = comboBoxTurno.SelectedItem.ToString();
            string sexo = comboBoxSexo.SelectedItem.ToString();
            string especialidad = comboBoxEspecialidad.SelectedItem.ToString();
            string modulo = comboBoxModulo.SelectedItem.ToString();
            int repetidor=0;
            if (checkBoxRepetidor.Checked==true)
            {
                repetidor = 1;
            }
            else 
            {
                repetidor = 0;
            }
            string cadena = "insert into Alumno(dni,nombre,turno,sexo,especialidad,modulo,repetidor) values ('" + dni + "','" + nombre + "','" + turno + "','" + sexo + "','" + especialidad + "','" + modulo + "'," + repetidor+ ") ";


            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos se guardaron correctamente");
            TxtDNI.Text = "";
            TxtNombre.Text = "";
            comboBoxTurno.SelectedItem = null;
            comboBoxSexo.SelectedItem = null;
            comboBoxEspecialidad.SelectedItem = null;
            comboBoxModulo.SelectedItem = null;
            this.ListarAlumnos();
            conexion.Close();

        }

        //DAR DE BAJA
        private void Btnbaja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string dni = TxtDNI.Text;
            string cadena = "delete from Alumno where DNI='" + dni+"'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                TxtDNI.Text = "";
                TxtNombre.Text = "";
                comboBoxTurno.SelectedItem = null;
                comboBoxSexo.SelectedItem = null;
                comboBoxEspecialidad.SelectedItem = null;
                comboBoxModulo.SelectedItem = null;

                MessageBox.Show("Se borró el Alumno");
            }
            else
                MessageBox.Show("No existe el Alumno con el DNI ingresado");
            this.ListarAlumnos();
            conexion.Close();
        }



         //MODFICAR ALUMNO
        private void BtnModificacion_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string dni = TxtDNI.Text;
            string nombre = TxtNombre.Text;
            string turno = comboBoxTurno.SelectedItem.ToString();
            string sexo = comboBoxSexo.SelectedItem.ToString();
            string especialidad = comboBoxEspecialidad.SelectedItem.ToString();
            string modulo = comboBoxModulo.SelectedItem.ToString();
            int repetidor = 0;
            if (checkBoxRepetidor.Checked == true)
            {
                repetidor = 1;
            }
            else
            {
                repetidor = 0;
            }
            string cadena = "update Persona set DNI='" + dni + "',Nombre='" + nombre + "',Turno='" + turno + "',Sexo='" + sexo + "',Especialidad='" + especialidad + "',Modulo='" + modulo + "',Repetidor" + repetidor + ",";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del Alumno");
                TxtDNI.Text = "";
                TxtNombre.Text = "";
                comboBoxTurno.SelectedItem = null;
                comboBoxSexo.SelectedItem = null;
                comboBoxEspecialidad.SelectedItem = null;
                comboBoxModulo.SelectedItem = null;
              
            }
            else
                MessageBox.Show("No existe El alumno con el DNI ingresado");
            this.ListarAlumnos();
            conexion.Close();
        }
    }
}
