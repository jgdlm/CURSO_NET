using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIOLINQYLAMBDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext BasedeDatos = new DataClasses1DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrid();
        }

        void cargarCombo()
        {
            var cargaCombo = from p in BasedeDatos.Products
                             select p.ProductName;
            comboBox1.DataSource = cargaCombo;
        }

        void cargarGrid()
        {
            var cargaGrid = from p in BasedeDatos.Products select p;
            GridDatos.DataSource = cargaGrid;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Products MyProduct = new Products();
            MyProduct.ProductName = TxtProd.Text;
            MyProduct.UnitPrice = int.Parse(TxtPrec.Text);
            MyProduct.UnitsInStock = short.Parse(TxtStock.Text);
            MyProduct.CategoryID = int.Parse(TxtCat.Text);
            BasedeDatos.Products.InsertOnSubmit(MyProduct);
            BasedeDatos.SubmitChanges();
            cargarGrid();
            cargarCombo();

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            //Sentencia Lambda
            Products MyProducto = BasedeDatos.Products.Single(p => p.ProductName == comboBox1.SelectedItem.ToString());
            MyProducto.ProductName = comboBox1.SelectedItem.ToString();
            MyProducto.UnitPrice = int.Parse(TxtPrec.Text);
            MyProducto.UnitsInStock = short.Parse(TxtStock.Text);
            MyProducto.CategoryID = int.Parse(TxtCat.Text);
            BasedeDatos.SubmitChanges();
            cargarGrid();
            cargarCombo();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {  
            //Sentencia Lambda
            Products MyProduct = BasedeDatos.Products.Single(p => p.ProductName == comboBox1.SelectedItem.ToString());
            BasedeDatos.Products.DeleteOnSubmit(MyProduct);
            BasedeDatos.SubmitChanges();
            cargarGrid();
            cargarCombo();
        }
    }
}
