using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VulnerApp
{
    public partial class RecuperarClave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hlVolver.NavigateUrl = "~/Login.aspx?user=<script>alert('Xss')</script>";
        }
    }
}