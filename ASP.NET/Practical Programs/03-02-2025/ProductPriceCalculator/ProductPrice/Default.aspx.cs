using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductPrice
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProducts.SelectedIndex == 0)
            {
                error.Text = "Please select a product.";
                error.Visible = true;
                imgProduct.ImageUrl = "";
                return;
            }
            else if (ddlProducts.SelectedIndex == 1)
            {
                imgProduct.ImageUrl = "~/images/water_bottle.png";
            }
            else if (ddlProducts.SelectedIndex == 2)
            {
                imgProduct.ImageUrl = "~/images/books.jpg";
            }
            else if (ddlProducts.SelectedIndex == 3)
            {
                imgProduct.ImageUrl = "~/images/pens.jpg";
            }

            lblFinalCost.Text = "FInal Price: " + int.Parse(ddlProducts.SelectedValue) + "$";
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text)){
                error.Text = "Enter Quantity";
            }
            else
            {
                lblTotalPrice.Text = "Total Price: " + int.Parse(ddlProducts.SelectedValue) * int.Parse(txtQuantity.Text) + "$"; 
            }
        }
    }
}