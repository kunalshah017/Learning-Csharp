using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBox
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CustomListBox.Items.Add(ListItemInput.Text);
        }

        protected void CustomListBox_IndexChange(object sender, EventArgs e)
        {
            SelectedItems.Text = "Selected Items: ";

            foreach (ListItem listItem in CustomListBox.Items)
            {
                if (listItem.Selected)
                {
                    SelectedItems.Text = SelectedItems.Text + listItem.Value + " ";
                }
            }
        }
    }
}