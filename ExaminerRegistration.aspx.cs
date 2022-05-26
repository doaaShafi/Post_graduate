using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace PostGradOfficeeeweb
{
    public partial class ExaminerRegistration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void examinerRegister_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String name1 = name.Text; //name of variable must be different from name of textbox id
            String FieldofWork1 = FieldofWork.Text;
            String isNational1 = isNational.Text;
            String pass = password.Text;
            String email1 = email.Text;

            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(FieldofWork.Text) ||
               string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(isNational.Text))
            {
                Response.Write("Please Complete your Information");
            }

            else if (isNational1 != "0" & isNational1 != "1") {
                Response.Write("Please Enter a 0 or 1 in isNational field");
            }


            else
            {

                SqlCommand loginProc = new SqlCommand("ExaminerRegister", conn);
                loginProc.CommandType = CommandType.StoredProcedure;

                loginProc.Parameters.Add(new SqlParameter("@name", name1));
                loginProc.Parameters.Add(new SqlParameter("@fieldOfWork", FieldofWork1));
                loginProc.Parameters.Add(new SqlParameter("@password", pass));
                loginProc.Parameters.Add(new SqlParameter("@isNational", isNational1));
                loginProc.Parameters.Add(new SqlParameter("@email", email1));



                conn.Open();
                loginProc.ExecuteNonQuery();

                conn.Close();
                Response.Redirect("Login.aspx");
            }
        }

    }
    }
