using System;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class leaveapplicatin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get employee name from Cookie
                if (Request.Cookies["empName"] != null)
                {
                    TextBox1.Text = Request.Cookies["empName"].Value;
                }

                // Get employee name from Session if available
                if (Session["EmpName"] != null)
                {
                    TextBox1.Text = Session["EmpName"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Check employee name
            if (TextBox1.Text == "")
            {
                Response.Write("<script>alert('Please enter employee name');</script>");
                return;
            }

            // Check reason
            if (TextBox2.Text == "")
            {
                Response.Write("<script>alert('Please enter reason for leave');</script>");
                return;
            }

            // Store employee name in Session
            Session["EmpName"] = TextBox1.Text;

            // Store employee name in Cookie
            HttpCookie cookie = new HttpCookie("empName");
            cookie.Value = TextBox1.Text;
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cookie);

            // Get selected date
            string leaveDate = Calendar1.SelectedDate.ToString("dd/MM/yyyy");

            // Get leave type
            string leaveType = DropDownList1.SelectedItem.Text;

            // Get reason
            string reason = TextBox2.Text;

            // Display submitted information
            Response.Write("<script>alert('Leave Application Submitted Successfully!');</script>");

            // Display in Output window/browser
            Response.Write("<br/><b>Employee Name:</b> " + TextBox1.Text);
            Response.Write("<br/><b>Leave Date:</b> " + leaveDate);
            Response.Write("<br/><b>Leave Type:</b> " + leaveType);
            Response.Write("<br/><b>Reason:</b> " + reason);
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            // This event runs when a date is selected
            string selectedDate = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
        }
    }
}