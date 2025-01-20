using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(usernameInput.Text == "Kunal" && passwordInput.Text == "2005")
            {
                Response.Redirect("LoginSuccess.aspx");
            }
            else
            {
                Response.Redirect("Error.aspx");
            }
        }
    }
}