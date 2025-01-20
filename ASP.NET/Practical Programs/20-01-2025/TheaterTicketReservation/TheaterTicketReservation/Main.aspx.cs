using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheaterTicketReservation
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            selectTheaterContainer.Visible = false;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectTheaterContainer.Visible = true;

            if (CityRadio.SelectedValue == "Mumbai")
            {
                theaterList.Items.Clear();
                theaterList.Items.Add("Viviana Mall");
                theaterList.Items.Add("Phoenix Mall");
            }

            else if (CityRadio.SelectedValue == "Pune")
            {
                theaterList.Items.Clear();
                theaterList.Items.Add("Metro Mall");
                theaterList.Items.Add("Cine Max");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            selectTheaterContainer.Visible = true;
            showTimingsHeader.Visible = true;
            showTimingsOutput.Visible = true;

            if (theaterList.SelectedValue == "Viviana Mall" || theaterList.SelectedValue == "Metro Mall")
            {
                showTimingsOutput.Text = "<ul><li>Main Tera Hero 10:00AM To 12:00PM</li><li>Avengers 3:00PM To 5:00PM</li><li>Robot 4:00PM To 6:00PM</li></ul>";
            }

            else if (theaterList.SelectedValue == "Cine Max" || theaterList.SelectedValue == "Phoenix Mall")
            {
                showTimingsOutput.Text = "<ul><li>Iron Man 10:00AM To 12:00PM</li><li>Ra.One 3:00PM To 5:00PM</li><li>Krrish 3 5:00PM To 7:00PM</li></ul>";
            }
        }
    }
}