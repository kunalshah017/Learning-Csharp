using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrossPageScripting
{
    public partial class Output : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                string username = ((TextBox)PreviousPage.FindControl("UserNameInput")).Text;
                string selectedColor = ((DropDownList)PreviousPage.FindControl("ColorDropDown")).SelectedValue;

                OutputLabel.Text = $"Welcome, <span style='color:{selectedColor}'>{username}</span>!";
            }

        }
    }
}