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
    public partial class ViewCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("ViewCoursesGrades", conn);
            courses.CommandType = CommandType.StoredProcedure;
            if (Session["user"] != null)
            {
                int id = (int)Session["user"];

                courses.Parameters.Add(new SqlParameter("@studentID", id));

                conn.Open();
                SqlDataReader reader = courses.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString(reader.GetOrdinal("code"));
                    decimal grd = reader.GetDecimal(reader.GetOrdinal("grade"));
                    Label a = new Label();
                    Label b = new Label();
                    a.Text = name+"<br>";
                    b.Text = grd.ToString() + "<br>";
                    form1.Controls.Add(a);
                    form1.Controls.Add(b);
                }
                conn.Close();
            }

        }
    }
}

        
    
