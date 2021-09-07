using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPValidacion
{
    public partial class formularioValidacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (IsValid && chkTerminos.Checked == true)
                Response.Redirect("Acceso.html");

            else if (chkTerminos.Checked == false)
            {
                Label15.Text = " Debe acpetar los terminos";
            }
        }
    }
}