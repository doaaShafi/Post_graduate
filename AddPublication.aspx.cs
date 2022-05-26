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
    public partial class AddPublication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand add = new SqlCommand("addPublication", conn);
            add.CommandType = CommandType.StoredProcedure;

            if (Session["user"] != null)
            {
                if (string.IsNullOrEmpty(a.Text) || string.IsNullOrEmpty(b.Text) || string.IsNullOrEmpty(c.Text) || string.IsNullOrEmpty(d.Text) || string.IsNullOrEmpty(f.Text))
                {
                    Response.Write("Please Complete your Information");
                }
                else
                {
                    String title = a.Text;
                    String host = b.Text;
                    String place = c.Text;
                    String date1 = d.Text;
                    String accepted = f.Text;
                    DateTime date2 = Convert.ToDateTime(date1);

                    add.Parameters.Add(new SqlParameter("@title", title));
                    add.Parameters.Add(new SqlParameter("@host", host));
                    add.Parameters.Add(new SqlParameter("@place", place));
                    add.Parameters.Add(new SqlParameter("@pubDate", date2));
                    add.Parameters.Add(new SqlParameter("@accepted", accepted));


                    conn.Open();
                    add.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("added");
                }
            }
        }
    }

}