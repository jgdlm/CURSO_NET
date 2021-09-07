using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CUESTIONARIOASP_NET
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int correctas = 0;

            if (RadioButton1.Checked == true) { correctas = correctas + 1; }
            if (RadioButton5.Checked == true) { correctas = correctas + 1; }
            if (RadioButton11.Checked == true) { correctas = correctas + 1; }
            if (RadioButton16.Checked == true) { correctas = correctas + 1; }
            Label1.Text = correctas + " preguntas correctas";

            if (IsValid) Response.Redirect("Acceso Permitido.aspx");
        }
    }
}