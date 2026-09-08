using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;

            lblSelectedData.Text =
                "Selected Date: " + selectedDate.ToString("dd/MM/yyyy");

            // Store selected leave date in Session
            Session["leaveDate"] = selectedDate;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Check if date is selected
            if (Calendar1.SelectedDate == DateTime.MinValue)
            {
                lblSelectedData.Text = "Please select a date first.";
                return;
            }

            // Store date in Session
            Session["leaveDate"] = Calendar1.SelectedDate;

            // Redirect to leave application page
            Response.Redirect("leaveapplicatin.aspx");
        }
    }
}