using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridCrud
{
    public partial class CrudOps : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearForm();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Only handle insert operations
            sdsStudents.Insert();
            lblMessage.Text = "Record added successfully!";
            ClearForm();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtStudentName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            ddlGender.SelectedIndex = 0;
            lblMessage.Text = string.Empty;
        }
    }
}
