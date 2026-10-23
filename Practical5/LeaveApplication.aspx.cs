// Name: Omkar Singh
// Enrollment No: 92400120399
using System;
using System.Web;

namespace AcademicLeaveManagement
{
    public partial class LeaveApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Session check: only a logged-in student may open this page
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                lblWelcome.Text = "Welcome, " + Session["Username"] + "!";
            }
        }

        protected void calLeaveDate_SelectionChanged(object sender, EventArgs e)
        {
            lblSelectedDate.Text = "Selected Date: " +
                calLeaveDate.SelectedDate.ToString("dddd, dd MMMM yyyy");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApplication.Text))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please write your leave application.";
                return;
            }

            if (calLeaveDate.SelectedDate == DateTime.MinValue)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please select a leave date.";
                return;
            }

            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Leave application submitted successfully for " +
                calLeaveDate.SelectedDate.ToString("dd MMM yyyy") + ".";
            txtApplication.Text = string.Empty;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear the session
            Session.Clear();
            Session.Abandon();

            // Expire the cookie
            if (Request.Cookies["StudentCookie"] != null)
            {
                HttpCookie cookie = new HttpCookie("StudentCookie");
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }

            Response.Redirect("Login.aspx");
        }
    }
}
