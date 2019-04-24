using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APMS
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            lblErrorMessage.Visible = false;

            Control myControlMenu = Page.Master.FindControl("Menu1");
            if (myControlMenu != null)
            {
                myControlMenu.Visible = false;
            }
            
        }

        protected void btnLogin(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            int value = dal.loginVerify(txtLoginName.Text, txtLoginPwd.Text);
            lblMessage.Visible = true;

            if (value > 0)
            {
                Session["username"] = txtLoginName.Text.Trim();
                Response.Redirect("Home.aspx");

                Control myControlMenu = Page.Master.FindControl("Menu1");
                if (myControlMenu != null)
                {
                    myControlMenu.Visible = false;
                }

            }
            else
            {
                lblMessage.Visible = true;
            }

        }
    }
}