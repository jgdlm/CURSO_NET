using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRIMERPROYECTOASPNET
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Button1_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int x1 = 0;
            int x2 = 0;

            if(Sumar.Checked)
            {
                x1 = int.Parse(TextBox1.Text);
                x2 = int.Parse(TextBox2.Text);
                resultado = x1 + x2;
                Label4.Text = resultado.ToString();
            }
            if (Restar.Checked)
            {
                x1 = int.Parse(TextBox1.Text);
                x2 = int.Parse(TextBox2.Text);
                resultado = x1 - x2;
                Label4.Text = resultado.ToString();
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}