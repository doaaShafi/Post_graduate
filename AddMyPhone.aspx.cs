using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;

namespace PostGradOfficeeeweb
{
    public partial class AddMyPhone : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addtelephone_Click(object sender, EventArgs e)

        { 
            String mobile = addtelephone.Text;
            Response.Write("mobile: "+mobile);
            if(string.IsNullOrEmpty(addtelephone.Text) )
                 {
                Response.Write("Please Enter your Phone");
            }

            else { 
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
                if (Session["user"] != null)
                {
                    int id = (int)Session["user"];
                    Response.Write(id);

                    SqlCommand addmobile = new SqlCommand("addMobile", conn);
                    addmobile.CommandType = CommandType.StoredProcedure;

                    addmobile.Parameters.Add(new SqlParameter("@ID", id));
                    addmobile.Parameters.Add(new SqlParameter("@mobile_number", mobile));


                    conn.Open();
                    addmobile.ExecuteNonQuery();
                    conn.Close();

                    //Response.Redirect();
                }



            }

        }
    }
}