using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextEditor
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void User_Input_Change(object sender, EventArgs e)
        {
            Output_Text.Text = User_Input.Text;
        }

        protected void Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Color_Change.SelectedValue == "Red")
            {
                Output_Text.ForeColor = System.Drawing.Color.Red;
            }
            
            if(Color_Change.SelectedValue == "Green")
            {
                Output_Text.ForeColor = System.Drawing.Color.Green;
            }
            
            if(Color_Change.SelectedValue == "Blue")
            {
                Output_Text.ForeColor = System.Drawing.Color.Blue;
            }
        }

        protected void Text_Style_Change(object sender, EventArgs e)
        {
            if (Bold.Checked)
            {
                Output_Text.Font.Bold = true;
            } else
            {
                Output_Text.Font.Bold = false;
            }

            if (Italics.Checked)
            {
                Output_Text.Font.Italic = true;
            }
            else
            {
                Output_Text.Font.Italic = false;
            }

            if (Underlined.Checked)
            {
                Output_Text.Font.Underline = true;
            }
            else
            {
                Output_Text.Font.Underline= false;
            }
        }
    }
}