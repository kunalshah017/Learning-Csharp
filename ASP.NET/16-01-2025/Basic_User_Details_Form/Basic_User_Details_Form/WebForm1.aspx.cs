using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Basic_User_Details_Form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            showName.Visible = true;
            showName.Text = name.Text;

            showMobile.Visible = true;
            showMobile.Text = mobile.Text;

            showGender.Visible = true;
            showGender.Text = gender.Text;

            showLang.Visible = true;
            showLang.Text = lang.Text;
        }
    }
}