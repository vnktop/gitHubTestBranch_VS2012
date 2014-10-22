using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace gitHubTestBranch_VS2012
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void login_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Membership.ValidateUser(login.UserName, login.Password))
                if (Roles.IsUserInRole(login.UserName, "Administrador"))
                    Response.Redirect("~/Admon/Admon.aspx");
                else lblmsg.Text = "usuario no admon";
            else
                lblmsg.Text = "credencial no valida";
        }
    }
}