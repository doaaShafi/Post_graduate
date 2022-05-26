using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace PostGradOfficeeeweb
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new(connStr);

            String Email1 = Email.Text;
            String pass = password.Text;

            if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(password.Text) )
            {
                Response.Write("Please Complete your Information");
            }

            else
            {



                SqlCommand getidproc = new SqlCommand("get_id", conn);
                getidproc.CommandType = CommandType.StoredProcedure;

                getidproc.Parameters.Add(new SqlParameter("@email", Email1));
                SqlParameter gotid = getidproc.Parameters.Add("@id", SqlDbType.Int);
                gotid.Direction = ParameterDirection.Output;

                conn.Open();
                getidproc.ExecuteNonQuery();
                conn.Close();



                SqlCommand loginProc = new SqlCommand("userLogin", conn);
                loginProc.CommandType = CommandType.StoredProcedure;

                loginProc.Parameters.Add(new SqlParameter("@id", gotid.Value));
                loginProc.Parameters.Add(new SqlParameter("@password", pass));


                SqlParameter sucess = loginProc.Parameters.Add("@success", SqlDbType.Bit);
                sucess.Direction = ParameterDirection.Output;
                SqlParameter type = loginProc.Parameters.Add("@type", SqlDbType.Int);
                type.Direction = ParameterDirection.Output;

                conn.Open();
                loginProc.ExecuteNonQuery();
                conn.Close();
                if (sucess.Value.ToString() == "True")
                {
                    Session["user"] = gotid.Value;
                    //check user type 0-- > Student,1-- > Admin,2-- > Supervisor ,3-- > Examiner
                    if (type.Value.ToString() == "0")
                    {
                         Response.Redirect("StudentProfile.aspx");  //aspx of Student
                    }

                    if (type.Value.ToString() == "1")
                    {
                        Response.Redirect("AdminMainPage.aspx");  //aspx of Admin
                    }

                    if (type.Value.ToString() == "2")
                    {
                        Response.Redirect("Supervisor.aspx");  //aspx of Supervisor
                    }

                    if (type.Value.ToString() == "3")
                    {
                        Response.Redirect("Examinerpage.aspx");  //aspx of Examiner 
                    }



                }

                else {

                    Response.Write("Invalid Email or Password");
                    Response.Write(sucess.Value.ToString());

                }


            }  }

        protected void needRegistartion_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("Registration.aspx");

        }
    }
}