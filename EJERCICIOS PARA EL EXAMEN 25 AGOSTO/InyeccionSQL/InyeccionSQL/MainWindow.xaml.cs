using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace InyeccionSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //EN PRIMER LUGAR DEFINIR LA CADENA DE CONEXIÓN A VUESTRA DDBB
        private SqlConnection conexion = new SqlConnection("server=ASATA403\\SQLEXPRESSJUANMA;initial Catalog=PruebaINyeccionsql;" +
            "Persist Security info=True;User=sa;PassWord=1234;");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          //CONTROLAR ENTRADA DE TRY      
            try
            {
                //if(txtId3.Text!="" && txtNombre1.Text!="" && txtEdad1.Text != "")
                if (txtId3.Text != "" && txtNombre1.Text != "" && txtEdad1.Text != "")
                {
                    //ABRIR CONEXION
                    conexion.Open();

                    string iden = txtId.Text;
                    string nombre = txtNombre.Text;
                    string edad = txtEdad.Text;

                    //DEFINIMOS CADENA SQL Y LA LANZAMOS
                    string cadena = "insert into Personas(id,nombre,edad)" + "values(" + iden + ",'" + nombre + "'," + edad + ")";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    
                    
                    MessageBox.Show("los datos se han guardado correctamente");
                    txtId.Text = "";
                    txtNombre.Text = "";
                    txtEdad.Text = "";

                    //CERRAMOS CONEXION
                    conexion.Close();

                }
                else{
                    MessageBox.Show("Faltan datos");
                }
               
            }//AQUI CIERRA 
            catch
            {

               MessageBox.Show ("Ya  existe la clave en la base de datos");
                txtId.Text = "";
                txtNombre.Text = "";
                txtEdad.Text = "";
               
            }
               
               
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //BOTON DE BUSQUEDA QUE COMPRUEBA QUE EL ID EXISTE
            if (txtId2.Text != "")
            {
                //ABRIR CONEXION
                conexion.Open();
               
                string id = txtId2.Text;

                //DEFINIR CADENA SQL Y LA LANZAMOS
                string cadena = "select id,nombre,edad from Personas where id=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                
                //SE DEFINE UN SQLREADER PARA LEER EL REGISTRO BUSCADO
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    //PONE EL NOMBRE  LA EDAD EN LOS LABLE
                    lbNombre.Content = registro["nombre"].ToString();
                    LbEdad.Content = registro["edad"].ToString();
                    btConsulta.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("No existe un artículo con el código ingresado");
                }

                //CERRAMOS LA CONEXIÓN UNA VEZ COMPROBARDO SI EL ID EXISTE
                conexion.Close();

            }//FIN DE IF PARA COMPROBAR ENTRADA DEL ID
            else
            {
                MessageBox.Show("Faltan datos");
            }
     
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //BOTON PARA ELIMINAR SI BUSCO ANTERIORMENTE
            
            if (txtId2.Text != "")
            {
                //ABRIS CADENA CONEXION
                conexion.Open();

                string iden = txtId2.Text;

                //DEFINIR CADENA SQL PARA BORRAR EL REGISTRO Y EJECUTARLA
                string cadena = "delete from Personas where id=" + iden;
                SqlCommand comando = new SqlCommand(cadena, conexion);

                //COMPRUEBA SI ELIMINO EL REGISTRO
                int cant;

                //EN CANT GUARDAMOS EL NÚMERO DE REGISTROS ELIMINADOS
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    lbNombre.Content = "";
                    LbEdad.Content = "";
                    txtId2.Text = "";
                    MessageBox.Show("Se borrò el artículo");
                }
                else
                {
                    MessageBox.Show("No existe el registro con el código ingresado");

                    btnBorrar.IsEnabled = true;
                }
                conexion.Close();

            }
           
           

        }


        //BOTON DE BUSQUEDA PARA POSTERIORMENTE ACTUALIZAR
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //COMPROBARMOS QUE EL ID SE INTRODUJO
            if (txtId3.Text != "")
            {
                //ABRIMOS CONEXION
                conexion.Open();
                string cod = txtId3.Text;

                //DEFINIMOS LA CADENA SQL Y LA EJECUTAMOS
                string cadena = "select id,nombre,edad from Personas where id=" + cod;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                
                // SI LA ENCUENTRA VUELCA EL REGISTRO EN EL DATAREADER
                // Y PONE NOMBRE Y EDAD EN LOS TEXTBOX Y HABILITA EL
                // BOTON DE MODIFICAR

                if (registro.Read())
                {
                    txtNombre1.Text = registro["nombre"].ToString();
                    txtEdad1.Text = registro["edad"].ToString();
                    btnModifica.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("No existe el artículo con el código ingresado");

                }

                //CERRAMOS LA CONEXIÓN
                conexion.Close();
            }
            else
            {
                MessageBox.Show("faltan datos");
            }
            

        }


        //BOTON PARA MODIFICAR EL REGISTRO
        private void btnModifica_Click(object sender, RoutedEventArgs e)
        {
            //ABRIS LA CONEXIÓN
            conexion.Open();

            //SI ALGUN TEXTBOX ESTÁ EN BLANCO NO HARÍA EL IF
           if (txtId3.Text != "" && txtNombre1.Text != "" && txtEdad1.Text != "")
                {
                string id = txtId3.Text;
                string nombre = txtNombre1.Text;
                string edad = txtEdad1.Text;

                //DEFINIMOS LA CADENA SQL Y LA LANZAMOS
                string cadena = "update Personas set nombre='" + nombre + "', edad=" + edad + "where id=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();

                //EN CASO DE MODIFICARSE CON ÉXITO se guarda en la variable cant
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del artículo");
                    txtId3.Text = "";
                    txtNombre1.Text = "";
                    txtEdad1.Text = "";
                }
                else
                {
                    MessageBox.Show("No existe el articulo con el código ingresado");
                }

                //Aquí cerramos Conexión
                conexion.Close();
            }
            else
            {
                MessageBox.Show("faltan datos");
            }
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
