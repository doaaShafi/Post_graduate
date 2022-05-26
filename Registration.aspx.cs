using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace PostGradOfficeeeweb
{
    public partial class Registration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Studentbutton_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("StudentRegisterForum.aspx");


        }

        protected void Supervisorbutton_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("SupervisorRegistration.aspx");

        }

        protected void Examinerbutton_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("ExaminerRegistration.aspx");
        }

        
    }
}