using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APMS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
                Response.Redirect("Login.aspx");
            lblUserDetails.Text = "Username : " + Session["username"];          
           
        }

        protected void btnLogoutClick(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");            
        }
    }
}