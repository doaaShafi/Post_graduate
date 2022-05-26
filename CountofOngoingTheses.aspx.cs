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
    public partial class CountofOngoingTheses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand CountofgoingTheses = new SqlCommand("AdminViewOnGoingTheses", conn);
            CountofgoingTheses.CommandType = CommandType.StoredProcedure;
            SqlParameter Count = CountofgoingTheses.Parameters.Add("@thesesCount", SqlDbType.Int);
            Count.Direction = ParameterDirection.Output;

             conn.Open();

            CountofgoingTheses.ExecuteNonQuery();
            conn.Close();

            String headerlabel = "The number of On-going Theses is :" + "  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + " " + Count.Value;  //we Must add .Value to get the actual value
            Label counoftheses = new Label();
            counoftheses.Text = headerlabel;
            form1.Controls.Add(counoftheses);



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMainPage.aspx");
        }
    }
}