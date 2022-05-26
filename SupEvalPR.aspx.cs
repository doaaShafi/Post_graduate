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
    public partial class SupEvalPR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            String Thesis = ThesisSerialNo.Text;
            String Progress = PRNo.Text;
            String E = Eval.Text;

            if(string.IsNullOrEmpty(ThesisSerialNo.Text) || string.IsNullOrEmpty(PRNo.Text) || string.IsNullOrEmpty(Eval.Text))
            {
                Response.Write("Please Fill all Entries!");

            }
            else if (!(Eval.Text=="1" || Eval.Text=="2" || Eval.Text=="3"|| Eval.Text=="0"))
            {
                Response.Write("Please Enter an Evaluation Between 0 to 3");

            }
            else
            {
                int supId = int.Parse(Session["user"].ToString());

                SqlCommand checker = new SqlCommand("checkPRExist", conn);
                checker.CommandType = CommandType.StoredProcedure;

                checker.Parameters.Add(new SqlParameter("@supervisorID", supId));
                checker.Parameters.Add(new SqlParameter("@thesisSerialNo", Thesis));
                checker.Parameters.Add(new SqlParameter("@progressReportNo", Progress));

                SqlParameter checkerVal = checker.Parameters.Add("@value", SqlDbType.Bit);
                checkerVal.Direction = ParameterDirection.Output;

                conn.Open();
                checker.ExecuteNonQuery();
                conn.Close();
                if ((bool)checkerVal.Value == true)
                {



                    SqlCommand evalPR = new SqlCommand("EvaluateProgressReport", conn);
                    evalPR.CommandType = CommandType.StoredProcedure;


                    evalPR.Parameters.Add(new SqlParameter("@supervisorID", supId));
                    evalPR.Parameters.Add(new SqlParameter("@thesisSerialNo", Thesis));
                    evalPR.Parameters.Add(new SqlParameter("@progressReportNo", Progress));
                    evalPR.Parameters.Add(new SqlParameter("@evaluation", E));


                    conn.Open();
                    evalPR.ExecuteNonQuery();
                    conn.Close();

                    Response.Write("Evaluation was Succesful!");
                }
                else
                {
                    Response.Write("Incorrect Data, Please check your data then Try Again");

                }
            }

        }

        protected void Return_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("Supervisor.aspx");
        }
    }
}