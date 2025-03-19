using System;

namespace FavouriteBookSession
{
    public partial class FavouriteSports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if book selection exists in session
            if (Session["FavouriteBook"] == null)
            {
                Response.Redirect("FavouriteBook.aspx");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ddlSports.SelectedValue))
            {
                // Store the selected sport in session
                Session["FavouriteSport"] = ddlSports.SelectedValue;

                // Redirect to the display page
                Response.Redirect("DisplaySession.aspx");
            }
        }
    }
}
