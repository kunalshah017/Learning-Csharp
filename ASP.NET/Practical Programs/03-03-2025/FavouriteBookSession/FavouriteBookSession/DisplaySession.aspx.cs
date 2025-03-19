using System;

namespace FavouriteBookSession
{
    public partial class DisplaySession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if both selections exist in session
            if (Session["FavouriteBook"] == null || Session["FavouriteSport"] == null)
            {
                Response.Redirect("FavouriteBook.aspx");
            }
            else
            {
                // Display the selections from session
                lblBook.Text = Session["FavouriteBook"].ToString();
                lblSport.Text = Session["FavouriteSport"].ToString();
            }
        }
    }
}
