using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//Añadimos este usìng para la SQLConnection


namespace ASP_NET_SQLCONEXION_SQLCOMMAND
{
    public partial class modificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre,clave,mail from usuarios " + "where nombre='" + this.TextBox1.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                this.TextBox2.Text = registro["clave"].ToString();
                this.TextBox3.Text= registro["mail"].ToString();
            }
            else
            {
                this.Label4.Text = "No existe usuario con dicho nombre";
            }
            conexion.Close();
        }

        protected void BtnModificar_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("update usuarios set " + "clave='" + this.TextBox2.Text + "',mail='" + this.TextBox3.Text + "'where nombre='" + this.TextBox1.Text + "'", conexion);
            int cantidad = comando.ExecuteNonQuery();
            if(cantidad == 1)
            {
                this.Label5.Text = "Datos Modificados";
            }
            else 
            {
                this.Label5.Text = "No existe el usuario";
            }
            conexion.Close();

        }
    }
}