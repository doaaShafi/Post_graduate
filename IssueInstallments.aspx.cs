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
    public partial class IssueInstallments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMainPage.aspx");
        }

        protected void IssueInstalllement_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String Paymentid1 = paymentid.Text;
            String InstallStartDate1 = InstallStartDate.Text;

            if (string.IsNullOrEmpty(paymentid.Text) || string.IsNullOrEmpty(InstallStartDate.Text))
            {
                Response.Write("Please Complete the Fields");
            }

            else {

                //DateTime dt = DateTime.ParseExact(InstallStartDate.Text.Trim(), "yyyy/MM/dd", null);

                int paymentidint = int.Parse(paymentid.Text);

                SqlCommand issueinstallmentproc = new SqlCommand("AdminIssueInstallPayment", conn);
                issueinstallmentproc.CommandType = CommandType.StoredProcedure;

                issueinstallmentproc.Parameters.Add(new SqlParameter("@paymentID", paymentidint));
                issueinstallmentproc.Parameters.Add(new SqlParameter("@InstallStartDate", InstallStartDate1));




                SqlParameter success = issueinstallmentproc.Parameters.Add("@success", SqlDbType.Bit);
                success.Direction = ParameterDirection.Output;

                conn.Open();
                issueinstallmentproc.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString() == "True")
                {
                    Response.Write("The command has been done Successfully");
                }
                else
                {
                    Response.Write("Sorry this Payment ID is not in the System !!");
                }





            }

        }
    }
}