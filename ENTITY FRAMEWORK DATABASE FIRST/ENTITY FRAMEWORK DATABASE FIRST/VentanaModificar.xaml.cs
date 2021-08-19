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
using System.Windows.Shapes;

namespace ENTITY_FRAMEWORK_DATABASE_FIRST
{
    /// <summary>
    /// Lógica de interacción para VentanaModificar.xaml
    /// </summary>
    public partial class VentanaModificar : Window
    {
        COLEGIOEntities1 DbProfesores = new COLEGIOEntities1();
        int id ;
        public VentanaModificar(int IdProfesor)
        {
            InitializeComponent();
            id = IdProfesor;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Profesores MyProfe = (from m in DbProfesores.Profesores
            where m.Id == id
            select m).Single();
            MyProfe.Nombre = TxtNombre.Text;
            MyProfe.Especialidad = cmbEspec.Text;
            DbProfesores.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = DbProfesores.Profesores.ToList();
            this.Hide();
        }
    }
}
