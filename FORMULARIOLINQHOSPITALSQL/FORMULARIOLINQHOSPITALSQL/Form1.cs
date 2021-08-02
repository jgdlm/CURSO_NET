using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIOLINQHOSPITALSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext BaseDatosHospital = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        void cargarGrid()
        {
            try
            {
                var cargaGrid = from empleados in BaseDatosHospital.Empleados select empleados;
                GridDatos.DataSource = cargaGrid;
                int numero = cargaGrid.Count();
                TxtTotalRegistros.Text = numero.ToString();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO CARCAR LOS REGISTROS");
            }


        }

        //ALTA EMPLEADO HOSPITAL
        private void BtnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados MiEmpleado = new Empleados();
                MiEmpleado.Id = int.Parse(TxtID.Text);
                MiEmpleado.Nombre = TxtNombre.Text;
                MiEmpleado.Apellido = TxtApellido.Text;
                MiEmpleado.Edad = int.Parse(TxtEdad.Text);
                MiEmpleado.Casado = checkBoxEstadoCivil.Checked;
                BaseDatosHospital.Empleados.InsertOnSubmit(MiEmpleado);
                BaseDatosHospital.SubmitChanges();
                cargarGrid();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO DAR DE ALTA NINGUN EMPLADO, POR FAVOR REVISE LOS DATOS INTRODUCCIDOS");
            }
        }

        private void checkBoxEstadoCivil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //BAJA EMPLEADO HOSPITAL
        private void BtnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("EL EMPLEADO: " + TxtID.Text + " HA SIDO DADO DE BAJA CORRECTAMENTE");
                //Sentencia Lambda
                Empleados MiEmpleado = BaseDatosHospital.Empleados.Single(p => p.Id == int.Parse(TxtID.Text));
                BaseDatosHospital.Empleados.DeleteOnSubmit(MiEmpleado);
                BaseDatosHospital.SubmitChanges();
                cargarGrid();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO DAR DE BAJA NINGUN EMPLADO, POR FAVOR REVISE LOS DATOS INTRODUCCIDOS");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //MODIFICACION DE EMPLEADO
        private void BtnModif_Click(object sender, EventArgs e)
        {
           try
            {
                MessageBox.Show("EL EMPLEADO: " + TxtID.Text + " HA SIDO MODIFICADO CORRECTAMENTE");
                //Sentencia Lambda
                Empleados MiEmpleado = BaseDatosHospital.Empleados.Single(p => p.Id == int.Parse(TxtID.Text));
                MiEmpleado.Id = int.Parse(TxtID.Text);
                MiEmpleado.Nombre = TxtNombre.Text.ToString();
                MiEmpleado.Apellido = TxtApellido.Text;
                MiEmpleado.Edad = int.Parse(TxtEdad.Text);
                MiEmpleado.Casado = checkBoxEstadoCivil.Checked;
                BaseDatosHospital.SubmitChanges();
                cargarGrid();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO MODIFICAR NINGUN EMPLEADO, POR FAVOR REVISE LOS DATOS INTRODUCCIDOS");
            }

        }

        private void BtnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                var Buscar = from empleados in BaseDatosHospital.Empleados where
                empleados.Nombre == TxtBusca.Text select empleados;
                GridDatos.DataSource = Buscar;
                int numero = Buscar.Count();
                TxtTotalRegistros.Text = numero.ToString();
            }
            catch
            {
                MessageBox.Show("NO SE HA PODIDO HACER LA BUSQUEDA, POR FAVOR REVISE LOS DATOS INTRODUCCIDOS");
            }

        }
    }
}
