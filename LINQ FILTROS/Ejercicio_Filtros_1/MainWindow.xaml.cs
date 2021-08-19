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

namespace Ejercicio_Filtros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //INICIALIZAMOS LA CLASE DE CONTEXTO
        //SIEMPRE EN LA CLASE MAINWINDOW
        DatosjuevesDataContextDataContext filtro = new DatosjuevesDataContextDataContext();
        public MainWindow()
        {
            /// <summary>
            /// Inicializar Formulario y cargamos Grid con TODOS LOS DATOS
            /// </summary>
            InitializeComponent();
            cargarGrid();

        }

        void cargarGrid()
        {
            ///Metodo con LINQ para cargar el Datagrid
            var listagrid = from f in filtro.datosjueves
                            select f;
            DGV1.ItemsSource = listagrid;
        }
       
        void cargarGridCurso()
        {
            //AQUI FILTRAMOS LOS REGISTROS DEL CURSO
            //SELECCIONADO EN EL COMBO
            String curso = ComboBox1.Text;
            var listagrid = from f in filtro.datosjueves where
                            f.Curso == curso select f;
            DGV1.ItemsSource = listagrid;
        }

        /// <summary>
        ///METODO CON LINQ PARA FILTAR POR EL NOMBRE
        ///OJO CONTAINS ES LO MISMO QUE LIKE EN SQL
        ///Filtra en funcion del Nombre y del curso
        /// </summary>
        void cargarGridNombre(String cadena)
        {
            String curso = ComboBox1.Text;
            var listagrid = from f in filtro.datosjueves where
            f.Curso == curso && f.Nombre.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;

        }

        /// <summary>
        ///METODO CON LINQ PARA FILTAR POR EL APELLIDO
        ///OJO CONTAINS ES LO MISMO QUE LIKE EN SQL
        ///Filtra en funcion del Apellido y del Curso
        /// </summary>
        void cargarGridApellido(String cadena)
        {
            String curso = ComboBox1.Text;
            var listagrid = from f in filtro.datosjueves where
            f.Curso == curso && f.Apellido.Contains(cadena) select f;
            DGV1.ItemsSource = listagrid;
        }


        //MÉTODO QUE FILTRA POR APELLIDO Y NOMBRE
        void cargarGridApellidoNombre(String cadena, string cadena2)
        {
            String curso = ComboBox1.Text;
            var listagrid = from f in filtro.datosjueves where
            f.Curso == curso && f.Apellido.Contains(cadena) &&
            f.Nombre.Contains(cadena2) select f;
            DGV1.ItemsSource = listagrid;
        }


        //MÉTODO FILTAR PRO FECHA DE INSCRIPCION DESDE HASTA
        void cargarFechaInscripcionFechaDesdeFechaHasta(DateTime f1, DateTime f2)
        {
      
            var listagrid = from f in filtro.datosjueves 
                            where  f.Fecha_Insc >= f1 && f.Fecha_Insc <= f2 
                            select f;
            DGV1.ItemsSource = listagrid;
        }


        //MÉTODO FILTAR POR FECHA DE CONTRATACIÓN DESDE HASTA
        void cargarFechaContratacionFechaDesdeFechaHasta(DateTime f1, DateTime f2)
        {
            var listagrid = from f in filtro.datosjueves
                            where f.Fecha_Cont >= f1 && f.Fecha_Cont <= f2
                            select f;
            DGV1.ItemsSource = listagrid;
        }

        //METODO PARA FILTRAR POR TODAS LAS FECHAS INSCRIPCION Y CONTRATACIÓN (DESDE HASTA)
        void cargartodasFecha(DateTime f1, DateTime f2, DateTime f3, DateTime f4)
        {
            var listagrid = from f in filtro.datosjueves
                            where 
                            f.Fecha_Insc >= f1 && f.Fecha_Insc <= f2  && 
                            f.Fecha_Cont >= f3 && f.Fecha_Cont <= f4
                            select f;
            DGV1.ItemsSource = listagrid;
        }

        /// <summary>
        /// Habilitar y deshabilitar el Check de las fechas
        /// </summary>
        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {

            DatePicker1.IsEnabled = true;
        }

        private void CheckBox1_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker1.IsEnabled = false;

        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = true;
        }

        private void CheckBox2_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker2.IsEnabled = false;

        }

        private void CheckBox4_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker3.IsEnabled = true;
        }

        private void CheckBox4_UnChecked(object sender, RoutedEventArgs e)
        {

            DatePicker3.IsEnabled = false;
        }

        private void CheckBox5_Checked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = true;
        }

        private void CheckBox5_UnChecked(object sender, RoutedEventArgs e)
        {
            DatePicker4.IsEnabled = false;

        }

        /// <summary>
        ///Deshabilita instructores
        /// </summary>

        private void CheckBox3_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = true;
            CheckBox5.IsEnabled = true;
        }

        private void CheckBox3_UnChecked(object sender, RoutedEventArgs e)
        {
            CheckBox4.IsEnabled = false;
            CheckBox5.IsEnabled = false;

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
                cargarGridApellidoNombre(TextBox1.Text, TextBox2.Text);
            else if (TextBox1.Text != "" && TextBox2.Text == "")
                cargarGridNombre(TextBox1.Text);
            else if (TextBox1.Text == "" && TextBox2.Text != "")
                cargarGridApellido(TextBox2.Text);
            else cargarGridCurso();
        }

        private void BtnFiltraFecha_Click(object sender, RoutedEventArgs e)
        {
            //Método para cargar filtro por fecha de Inscripcion
            if (CheckBox1.IsChecked == true && CheckBox2.IsChecked == true)
                cargarFechaInscripcionFechaDesdeFechaHasta(DatePicker1.DisplayDate, DatePicker2.DisplayDate);

            //Método para cargar filtro por fecha de contratación
            else if (CheckBox4.IsChecked == true && CheckBox5.IsChecked == true)
                cargarFechaContratacionFechaDesdeFechaHasta(DatePicker3.DisplayDate, DatePicker4.DisplayDate);

            //Método para cargar filtro por todas
            else if (CheckBox1.IsChecked == true && CheckBox2.IsChecked == true && CheckBox4.IsChecked == true && CheckBox5.IsChecked == true) cargartodasFecha(DatePicker1.DisplayDate, DatePicker2.DisplayDate, DatePicker3.DisplayDate, DatePicker4.DisplayDate);


        }
    }
}
