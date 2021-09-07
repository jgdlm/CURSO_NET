using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//Añadimos este usìng para la SQLConnection

namespace ASP_NET_SQLCONEXION_SQLCOMMAND
{
    public partial class consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsultas_Click(object sender, EventArgs e)
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select nombre,clave,mail from usuarios " + "where nombre='" + this.TextBox1.Text + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if(registro.Read())
            {
                this.Label4.Text = "Clave:" + registro["clave"] + "<br>" + "Mail:" + registro["mail"];
            }
            else 
            {
                this.Label4.Text = "No existe usuario con dicho nombre";
            }
            conexion.Close();
        }
    }
}