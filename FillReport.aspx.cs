using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyApp
{
    public partial class FillReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void report(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand add = new SqlCommand("FillProgressReport", conn);
            add.CommandType = CommandType.StoredProcedure;

            if (Session["user"] != null)
            {
                if (string.IsNullOrEmpty(reportno.Text) || string.IsNullOrEmpty(desc.Text) || string.IsNullOrEmpty(serialno.Text) || string.IsNullOrEmpty(state.Text))
                {
                    Response.Write("Please Complete your Information");
                }
                else
                {
                    int id = (int)Session["user"];
                    String number = reportno.Text;
                    int num = Int32.Parse(number);
                    String serial = serialno.Text;
                    int ser = Int32.Parse(serial);
                    String des = desc.Text;
                    String state1 = state.Text;
                    int st = Int32.Parse(state1);

                    add.Parameters.Add(new SqlParameter("@studentId", id));
                    add.Parameters.Add(new SqlParameter("@thesisSerialNo", ser));
                    add.Parameters.Add(new SqlParameter("@progressReportNo", num));
                    add.Parameters.Add(new SqlParameter("@description", des));
                    add.Parameters.Add(new SqlParameter("@state", st));

                    conn.Open();
                    add.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
    
