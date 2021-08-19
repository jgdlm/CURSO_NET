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
    /// Lógica de interacción para VentanaInsertar.xaml
    /// </summary>
    public partial class VentanaInsertar : Window
    {
        COLEGIOEntities1 DbProfesores = new COLEGIOEntities1();
       
        public VentanaInsertar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          // intidulti = MyDataGrid.Items.Count+1;
            Profesores MyProfe = new Profesores()
            {
                Id = int.Parse(TxtID.Text),
                Nombre = TxtNombre.Text,
                Especialidad = cmbEspec.Text
            };
            DbProfesores.Profesores.Add(MyProfe);
            DbProfesores.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = DbProfesores.Profesores.ToList();
            this.Hide();
        }

    }
}
