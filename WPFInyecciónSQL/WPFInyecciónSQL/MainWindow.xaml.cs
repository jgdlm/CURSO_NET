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

        private void BtnInsertar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = TxtID.Text;
            string nombre = TxtNombre.Text;
            string edad = TxtEdad.Text;
            string cadena = "insert into Personas(ID,Nombre,Edad)" + "values ("+ iden + ",'" + nombre + ",'" + edad + ")";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Datos se guardaron correctamente");
            TxtID.Text = "";
            TxtNombre.Text = "";
            conexion.Close();

        }
    }
}
