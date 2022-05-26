using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace PostGradOfficeeeweb
{
    public partial class StudentRegisterForum : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GUCIAN_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String firstname1 = firstname.Text; //name of variable must be different from name of textbox id
            String lastname1 = lastname.Text;
            String faculty1 = faculty.Text;
            String address1 = Address.Text;
            String pass = password.Text;
            String email1 = Email.Text;

            if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(Address.Text) || string.IsNullOrEmpty(faculty.Text) ||
                string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text)) {
                Response.Write("Please Complete your Information");
            }

            /*  if (email1 == null)
              {
                  Response.Write("Please Enter an Email !");
              }

              else if (pass == null)
              {
                  Response.Write("Please Enter a Password");
              }

              else if (firstname1 == null)
              {
                  Response.Write("Please Enter your First name");

              }
              else if (lastname1 == null)
              {
                  Response.Write("Please Enter your Last name");
              }

              else if (address1 == null)
              {
                  Response.Write("Please Enter Your Address");
              }

              else if (faculty1 == null)
              {
                  Response.Write("Please Enter Your Faculty");
              }
            */

            else
            {

                SqlCommand loginProc = new SqlCommand("studentRegister", conn);
                loginProc.CommandType = CommandType.StoredProcedure;

                loginProc.Parameters.Add(new SqlParameter("@first_name", firstname1));
                loginProc.Parameters.Add(new SqlParameter("@last_name", lastname1));
                loginProc.Parameters.Add(new SqlParameter("@password", pass));
                loginProc.Parameters.Add(new SqlParameter("@faculty", faculty1));
                loginProc.Parameters.Add(new SqlParameter("@address", address1));
                loginProc.Parameters.Add(new SqlParameter("@Gucian", 1)); //we don't "" around a BIT value
                loginProc.Parameters.Add(new SqlParameter("@email", email1));

                conn.Open();
                loginProc.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Login.aspx");

            }
        }

        protected void NonGucian_Click(object sender, EventArgs e)
            {
                String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                String firstname1 = firstname.Text; //name of variable must be different from name of textbox id
                String lastname1 = lastname.Text;
                String faculty1 = faculty.Text;
                String address1 = Address.Text;
                String pass = password.Text;
                String email1 = Email.Text;

            if (email1 == null)
            {
                Response.Write("Please Enter an Email !");
            }

            else if (pass == null)
            {
                Response.Write("Please Enter a Password");
            }

            else if (firstname1 == null)
            {
                Response.Write("Please Enter your First name");

            }
            else if (lastname1 == null)
            {
                Response.Write("Please Enter your Last name");
            }

            else if (address1 == null)
            {
                Response.Write("Please Enter Your Address");
            }

            else if (faculty1 == null)
            {
                Response.Write("Please Enter Your Faculty");
            }




            else { 


        SqlCommand loginProc = new SqlCommand("studentRegister", conn);
                loginProc.CommandType = CommandType.StoredProcedure;

                loginProc.Parameters.Add(new SqlParameter("@first_name", firstname1));
                loginProc.Parameters.Add(new SqlParameter("@last_name", lastname1));
                loginProc.Parameters.Add(new SqlParameter("@password", pass));
                loginProc.Parameters.Add(new SqlParameter("@faculty", faculty1));
                loginProc.Parameters.Add(new SqlParameter("@address", address1));
                loginProc.Parameters.Add(new SqlParameter("@Gucian", 0)); //we don't "" around a BIT value
                loginProc.Parameters.Add(new SqlParameter("@email", email1));

                conn.Open();
                loginProc.ExecuteNonQuery();

                conn.Close();
                Response.Redirect("Login.aspx"); }

        }
    }
}