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
    public partial class IssueaThesisPayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BacktoAdminpage_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMainPage.aspx");

        }

        protected void IssuePayment_Click(object sender, EventArgs e)
        {
            String serialnumber = serialNo.Text;
            String amount1 = amount.Text;
            String NumberofInstallements1 = NumberofInstallements.Text;
            String FundPercentage1 = FundPercentage.Text;


            if (string.IsNullOrEmpty(serialNo.Text) || string.IsNullOrEmpty(amount.Text) || string.IsNullOrEmpty(NumberofInstallements.Text) || string.IsNullOrEmpty(FundPercentage.Text))
            {
                Response.Write("Please Complete all fields");
            }

            else
            {
                String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand issuePaymentpro = new SqlCommand("AdminIssueThesisPayment", conn);
                issuePaymentpro.CommandType = CommandType.StoredProcedure;

                int serialnumberint = int.Parse(serialNo.Text);
                decimal amontindecimal = decimal.Parse(amount.Text);
                int NumberofInstallementsint = int.Parse(NumberofInstallements.Text);
                decimal FundPercentageindecimal = decimal.Parse(FundPercentage.Text);
                

               

                issuePaymentpro.Parameters.Add(new SqlParameter("@ThesisSerialNo", serialnumberint));
                issuePaymentpro.Parameters.Add(new SqlParameter("@amount", amontindecimal));
                issuePaymentpro.Parameters.Add(new SqlParameter("@noOfInstallments", NumberofInstallementsint));
                issuePaymentpro.Parameters.Add(new SqlParameter("@fundPercentage", FundPercentageindecimal));

                SqlParameter success = issuePaymentpro.Parameters.Add("@success", SqlDbType.Bit);
                success.Direction = ParameterDirection.Output;

                conn.Open();
                issuePaymentpro.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString()== "True")
                {
                    Response.Write("The command has been done Successfully");
                }
                else {
                    Response.Write("Sorry this Thesis Serial number is not in the System !!");
                }












            }





















        }
    }
}