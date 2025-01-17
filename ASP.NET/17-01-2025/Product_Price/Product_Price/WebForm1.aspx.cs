using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Price
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int rate = int.Parse(selectProduct.SelectedValue);
            int quantiy = int.Parse(quantity.Text);

            totalPrice.Visible = true;
            totalPrice.Text = "Total Price: " + (rate * quantiy).ToString() + "₹";
        }
    }
}