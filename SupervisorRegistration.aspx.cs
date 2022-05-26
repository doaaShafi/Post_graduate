using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace PostGradOfficeeeweb
{
    public partial class SupervisorRegistration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String firstname1 = firstname.Text; //name of variable must be different from name of textbox id
            String lastname1 = lastname.Text;
            String faculty1 = faculty.Text;
            String pass = password.Text;
            String email1 = Email.Text;
            if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(faculty.Text) ||
                string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text))
            {
                Response.Write("Please Complete your Information");
            }


            else
            {
                SqlCommand loginProc = new SqlCommand("supervisorRegister", conn);
                loginProc.CommandType = CommandType.StoredProcedure;

                loginProc.Parameters.Add(new SqlParameter("@first_name", firstname1));
                loginProc.Parameters.Add(new SqlParameter("@last_name", lastname1));
                loginProc.Parameters.Add(new SqlParameter("@password", pass));
                loginProc.Parameters.Add(new SqlParameter("@faculty", faculty1));
                loginProc.Parameters.Add(new SqlParameter("@email", email1));



                conn.Open();
                loginProc.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Login.aspx");
            }
        }
    }
}