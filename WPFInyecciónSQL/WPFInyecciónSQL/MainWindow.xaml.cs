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
using System.Data.SqlClient; //Insertar este using

namespace WPFInyecciónSQL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Defines la conexión a la base de datos sql server
        private SqlConnection conexion = new SqlConnection("server = ASATA407\\SQLEXPRESSJORGE; Initial Catalog = INYECCIONSQL; Persist Security Info=true;Pwd=1234;User ID = sa");
        public MainWindow()
        {
            InitializeComponent();
        }

        //Insertar 
        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = TxtID.Text;
            string nombre = TxtNombre.Text;
            string edad = TxtEdad.Text;
            string cadena = "insert into Persona(ID,Nombre,Edad)" + " values (" + iden + ",'" + nombre + "'," + edad + ") ";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos se guardaron correctamente");
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtEdad.Text = "";
            conexion.Close();

        }

        //Consulta
        private void BtnConsulta_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string id = TxtID1.Text;
            string cadena = "select ID,Nombre,Edad from Persona where ID=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                Label1.Content = registro["Nombre"].ToString();
                Label2.Content = registro["Edad"].ToString();
                BtnEliminar.IsEnabled = true;
            }
            else
                MessageBox.Show("No existe un artcículo con el código ingresado");
            conexion.Close();
        }

        //Eliminar
        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = TxtID1.Text;
            string cadena = "delete from Persona where ID=" + iden;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                Label1.Content = "";
                Label2.Content = "";
                MessageBox.Show("Se borró el artículo");
            }
            else
                MessageBox.Show("No existe un artcículo con el código ingresado");
            conexion.Close();
            BtnConsulta.IsEnabled = false;
        }

        //Buscar
        private void BtnBusca_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string cod = TxtID2.Text;
            string cadena = "select ID,Nombre,Edad from Persona where ID=" + cod;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNombre1.Text = registro["Nombre"].ToString();
                TxtEdad1.Text = registro["Edad"].ToString();
                BtnModifica.IsEnabled = true;
            }
            else
                MessageBox.Show("No existe un artcículo con el código ingresado");
            conexion.Close();
        }

        private void BtnModifica_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string id = TxtID2.Text;
            string nombre = TxtNombre1.Text;
            string edad = TxtEdad1.Text;
            string cadena = "update Persona set Nombre='" + nombre + "', edad=" + edad + "where ID=" + id;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del artículo");
                TxtID2.Text = "";
                TxtNombre1.Text = "";
                TxtEdad1.Text = "";
            }
            else
            MessageBox.Show("No existe un artcículo con el código ingresado");
            conexion.Close();
            BtnModifica.IsEnabled = false;
        }
    }
}
