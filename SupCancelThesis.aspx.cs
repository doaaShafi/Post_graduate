using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostGradOfficeeeweb
{
    public partial class SupCancelThesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("Supervisor.aspx");
        }

        protected void CancelTh_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String Thesis = ThesisSr.Text;

            if (string.IsNullOrEmpty(ThesisSr.Text))
            {
                Response.Write("Please Enter the Thesis Serial Number That You Wish to Cancel");
            }
            else
            {

                

                SqlCommand checker = new SqlCommand("CancelThesisChecker", conn);
                checker.CommandType = CommandType.StoredProcedure;
                checker.Parameters.Add(new SqlParameter("@ThesisSerialNo", Thesis));

                SqlParameter checkerVal = checker.Parameters.Add("@value", SqlDbType.Bit);
                checkerVal.Direction = ParameterDirection.Output;

                conn.Open();
                checker.ExecuteNonQuery();
                conn.Close();


                SqlCommand cancelThesis = new SqlCommand("CancelThesis", conn);
                cancelThesis.CommandType = CommandType.StoredProcedure;



                cancelThesis.Parameters.Add(new SqlParameter("@ThesisSerialNo", Thesis));

                conn.Open();
                cancelThesis.ExecuteNonQuery();
                conn.Close();

                Response.Write("Operation was Succesful!");

                if((bool)checkerVal.Value == true)
                    Response.Write("The Thesis has been deleted");
                else
                    Response.Write("The Thesis has not been deleted, as the last progress report evaluation is not 0");

            }
        }
    }
}