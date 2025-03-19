using System;

namespace FavouriteBookSession
{
    public partial class FavouriteBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ddlBooks.SelectedValue))
            {
                // Store the selected book in session
                Session["FavouriteBook"] = ddlBooks.SelectedValue;

                // Redirect to the sports selection page
                Response.Redirect("FavouriteSports.aspx");
            }
        }
    }
}
