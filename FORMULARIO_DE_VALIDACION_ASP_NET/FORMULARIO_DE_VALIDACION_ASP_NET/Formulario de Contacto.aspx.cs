using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FORMULARIO_DE_VALIDACION_ASP_NET
{
    public partial class Formulario_de_Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            if (CheckBox1.Checked == true)
            {
                Label16.Text = "Ha Aceptado los Terminos y Condiciones";
            }
            else
            {
                Label16.Text = "No Ha Aceptado los Terminos y Condiciones";
                return;
            }
        }
    }
}