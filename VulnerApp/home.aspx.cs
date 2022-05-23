using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VulnerApp
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido, " + Request.QueryString["user"];
            if(Session["InfoUsuario"] != null)
            {
                DataTable dt = (DataTable)Session["InfoUsuario"];
                gvResultado.DataSource = dt;
                gvResultado.DataBind();
            }
        }
    }
}