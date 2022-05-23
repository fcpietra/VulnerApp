using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VulnerApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BadLogin.PasswordRecoveryUrl = "~/RecuperarClave.aspx?user=";
        }

        protected void BadLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LV8AUDP;Initial Catalog=VulnerApp;Integrated Security=True");
            string qry = "select * from Usuarios where NombreUsuario='" + BadLogin.UserName + "'and Clave='" + BadLogin.Password + "' ";
            SqlDataAdapter adpt = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                Session["InfoUsuario"] = dt;
                Response.Redirect("home.aspx?user=" + BadLogin.UserName);
            }
        }
    }
}