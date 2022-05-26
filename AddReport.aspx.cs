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
    public partial class AddReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void report(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand add = new SqlCommand("AddProgressReport", conn);
            add.CommandType = CommandType.StoredProcedure;

            SqlCommand check = new SqlCommand("isItYou", conn);
            check.CommandType = CommandType.StoredProcedure;

            SqlCommand key = new SqlCommand("chech", conn);
            key.CommandType = CommandType.StoredProcedure;


            if (Session["user"] != null)
            {
                if (string.IsNullOrEmpty(reportno.Text) || string.IsNullOrEmpty(date.Text) || string.IsNullOrEmpty(serialno.Text))
                {
                    Response.Write("Please Complete your Information");
                }
                else { 
                int id = (int)Session["user"];
                String number = reportno.Text;
                int num = Int32.Parse(number);
                String date1 = date.Text;
                String serial = serialno.Text;
                int ser = Int32.Parse(serial);
                DateTime date2 = Convert.ToDateTime(date1);

                    check.Parameters.Add(new SqlParameter("@studentID", id));
                    check.Parameters.Add(new SqlParameter("@serial", ser));

                    key.Parameters.Add(new SqlParameter("@studentID", id));
                    key.Parameters.Add(new SqlParameter("@no",num));
                    SqlParameter c1 = key.Parameters.Add("@c", SqlDbType.Bit);
                    c1.Direction = ParameterDirection.Output;
                    conn.Open();
                    key.ExecuteNonQuery();
                    conn.Close();

                    SqlParameter c = check.Parameters.Add("@success", SqlDbType.Bit);
                    c.Direction = ParameterDirection.Output;
                    conn.Open();
                    check.ExecuteNonQuery();
                    conn.Close();

                    add.Parameters.Add(new SqlParameter("@studentId", id));
                    add.Parameters.Add(new SqlParameter("@thesisSerialNo", ser));
                    add.Parameters.Add(new SqlParameter("@progressReportNo", num));
                    add.Parameters.Add(new SqlParameter("@progressReportDate", date2));

                    if (c.Value.ToString() == "True")
                    {
                        if (c1.Value.ToString() == "True")
                        {
                            Response.Write("Already Exists");
                        }
                        else
                        {
                            conn.Open();
                            add.ExecuteNonQuery();
                            conn.Close();
                            Response.Write("added");
                        }
                    }
                    else
                    {
                        Response.Write("pleade enter valid serial number");
                    }
                }
            }
        }
    }
}
    
