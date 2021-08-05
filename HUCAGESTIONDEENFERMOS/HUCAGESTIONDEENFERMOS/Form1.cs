using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HUCAGESTIONDEENFERMOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext BasedeDatosEnfermos = new DataClasses1DataContext();

        private void radioButtonHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        void cargarGrid()
        {
            try
            {
                var cargaGrid = from p in BasedeDatosEnfermos.Enfermo select p;
                GridDatos.DataSource = cargaGrid;
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO CARCAR LOS REGISTROS");
            }
        }

        void reset()
        {
            try
            {
                TxtInscripcion.Text = "";
                TxtNombreApellidos.Text = "";
                dateTimePickerFecha.Value = DateTime.Now;
                TxtDireccion.Text = "";
                radioButtonMujer.Checked = true;
                radioButtonHombre.Checked = false;
                TxtSSocial.Text = "";
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO RESETEAR LOS CAMPOS");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Enfermo MiEnfermos = new Enfermo();
                MiEnfermos.Inscripcion = int.Parse(TxtInscripcion.Text);
                MiEnfermos.NombreApellido = TxtNombreApellidos.Text;
                MiEnfermos.Fecha = dateTimePickerFecha.Value;
                 if (radioButtonMujer.Checked==true)
                 {
                    MiEnfermos.Sexo = "Mujer";
                  }
                  else { MiEnfermos.Sexo = "Hombre"; }
                MiEnfermos.Direccion = TxtDireccion.Text;
                MiEnfermos.Numero_de_la_SS = int.Parse(TxtSSocial.Text);
                BasedeDatosEnfermos.Enfermo.InsertOnSubmit(MiEnfermos);
                BasedeDatosEnfermos.SubmitChanges();
                cargarGrid();
                TxtMuestraMensajes.Text = "EL ENFERMO " + TxtNombreApellidos.Text + " HA SIDO INGRESADO";
                reset();
              
            }
            catch
            {
                TxtMuestraMensajes.Text = "NO SE HA PODIDO INGRESAR NINGUN ENFERMO, POR FAVOR REVISE LOS DATOS INTRODUCCIDOS";
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
              
                //Sentencia Lambda
                Enfermo MiEnfermos = BasedeDatosEnfermos.Enfermo.Single(p => p.Inscripcion == int.Parse(TxtInscripcion.Text));
                BasedeDatosEnfermos.Enfermo.DeleteOnSubmit(MiEnfermos);
                BasedeDatosEnfermos.SubmitChanges();
                cargarGrid();
                TxtMuestraMensajes.Text = "EL ENFERMO " + TxtInscripcion.Text + " HA SIDO DADO DE BAJA";
                reset();
            }
            catch
            {
                TxtMuestraMensajes.Text = "NO SE HA PODIDO DAR DE BAJA NINGUN ENFERMO, POR FAVOR REVISE LOS DATOS INTRODUCCIDOS";
            }
        }

        private void BtnUpDate_Click(object sender, EventArgs e)
        {
            try
            {
               
                //Sentencia Lambda
                Enfermo MiEnfermos = BasedeDatosEnfermos.Enfermo.Single(p => p.Inscripcion == int.Parse(TxtInscripcion.Text));
                MiEnfermos.Inscripcion = int.Parse(TxtInscripcion.Text);
                MiEnfermos.NombreApellido = TxtNombreApellidos.Text;
                MiEnfermos.Fecha = dateTimePickerFecha.Value;
                if (radioButtonMujer.Checked == true)
                {
                    MiEnfermos.Sexo = "Mujer";
                }
                else { MiEnfermos.Sexo = "Hombre"; }
                MiEnfermos.Direccion = TxtDireccion.Text;
                MiEnfermos.Numero_de_la_SS = int.Parse(TxtSSocial.Text);
                BasedeDatosEnfermos.SubmitChanges();
                cargarGrid();
                TxtMuestraMensajes.Text = "EL ENFERMO " + TxtInscripcion.Text + " HA SIDO DADO MODIFICADO SUS DATOS CORRECTAMENTE";
                reset();
            }
            catch
            {
                TxtMuestraMensajes.Text = "NO SE HA PODIDO MODIFICAR NINGUN ENFERMO, POR FAVOR REVISE LOS DATOS INTRODUCCIDOS";
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
          TxtInscripcion.Text = "";
          TxtNombreApellidos.Text = "";
          TxtDireccion.Text = "";
          radioButtonMujer.Checked = true;
          radioButtonHombre.Checked = false;
          TxtSSocial.Text = "";
        }
    }
}
