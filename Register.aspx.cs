using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;

namespace APMS
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            lblErrorMessage.Visible = false;
            lblFormSent.Visible = false;

            Control myControlMenu = Page.Master.FindControl("Menu1");
            if (myControlMenu != null)
            {
                myControlMenu.Visible = false;
            }
        }

        protected void btnRegister(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            txtPwd.Text = Security.GetHash(txtPwd.Text);
            dal.registerUser(txtFN.Text, txtLN.Text, txtUserName.Text, txtPwd.Text, txtMob.Text, txtHmPhone.Text, txtEmail.Text);
            clear();
        }

        void clear()
        {
            txtFN.Text = "";
            txtLN.Text = "";
            txtUserName.Text = "";
            txtPwd.Text = "";
            txtMob.Text = "";
            txtHmPhone.Text = "";
            txtEmail.Text = "";
        }
               
    }

}