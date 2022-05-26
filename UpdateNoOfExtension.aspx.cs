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
    public partial class UpdateNoOfExtension : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void backtoAdminPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMainPage.aspx");

        }

        protected void updatenoofExtensions_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String ThesisSerialNO1 = ThesisSerialNO.Text;


            if (string.IsNullOrEmpty(ThesisSerialNO.Text))
            {
                Response.Write("Please Type the Thesis Serial Number");
            }


            else {
                int serial = int.Parse(ThesisSerialNO.Text);

                SqlCommand updateNoOfExtensions = new SqlCommand("AdminUpdateExtension", conn);
                updateNoOfExtensions.CommandType = CommandType.StoredProcedure;
                updateNoOfExtensions.Parameters.Add(new SqlParameter("@ThesisSerialNo",serial ));
                SqlParameter success = updateNoOfExtensions.Parameters.Add("@success", SqlDbType.Bit);
                success.Direction = ParameterDirection.Output;

                conn.Open();
                updateNoOfExtensions.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString() == "True")
                {

                    Response.Write("Command Completed Successfully");

                }

                else {

                    Response.Write("Sorry this Thesis Serial number is not in the System!!");

                }



            }

        }
    }
}