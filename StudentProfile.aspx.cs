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
    public partial class StudentProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand profileProc = new SqlCommand("viewMyProfile", conn);
            profileProc.CommandType = CommandType.StoredProcedure;
            if (Session["user"] != null)
            {
                int id = (int)Session["user"];
                SqlCommand typeProc = new SqlCommand("gucian", conn);
                typeProc.CommandType = CommandType.StoredProcedure;
                typeProc.Parameters.Add(new SqlParameter("@studentId", id));
                SqlParameter type = typeProc.Parameters.Add("@gucian", SqlDbType.Bit);
                type.Direction = ParameterDirection.Output;
                conn.Open();
                typeProc.ExecuteNonQuery();
                conn.Close();
                if (type.Value.ToString() == "True")
                {
                    profileProc.Parameters.Add(new SqlParameter("@studentId", id));

                    conn.Open();
                    SqlDataReader reader = profileProc.ExecuteReader();
                    while (reader.Read())
                    {
                        int my_id = reader.GetInt32(reader.GetOrdinal("id"));
                        int ID = reader.GetInt32(reader.GetOrdinal("undergradID"));
                        String first = reader.GetString(reader.GetOrdinal("firstName"));
                        String last = reader.GetString(reader.GetOrdinal("lastName"));
                        String fac = reader.GetString(reader.GetOrdinal("faculty"));
                        String add = reader.GetString(reader.GetOrdinal("address"));
                        String type1 = reader.GetString(reader.GetOrdinal("type"));
                        String em = reader.GetString(reader.GetOrdinal("email"));
                        decimal gpa = reader.GetDecimal(reader.GetOrdinal("GPA"));
                        a.Text = my_id.ToString();
                        b.Text = ID.ToString();
                        c.Text = first;
                        d.Text = last;
                        f.Text = fac;
                        g.Text = add;
                        h.Text = type1;
                        i.Text = em;
                        j.Text = gpa.ToString();
                    }
                    conn.Close();
                }
                else
                {
                    profileProc.Parameters.Add(new SqlParameter("@studentId", id));

                    conn.Open();
                    SqlDataReader reader = profileProc.ExecuteReader();
                    while (reader.Read())
                    {
                        int my_id = reader.GetInt32(reader.GetOrdinal("id"));
                        String first = reader.GetString(reader.GetOrdinal("firstName"));
                        String last = reader.GetString(reader.GetOrdinal("lastName"));
                        String fac = reader.GetString(reader.GetOrdinal("faculty"));
                        String add = reader.GetString(reader.GetOrdinal("address"));
                        String type1 = reader.GetString(reader.GetOrdinal("type"));
                        String em = reader.GetString(reader.GetOrdinal("email"));
                        decimal gpa = reader.GetDecimal(reader.GetOrdinal("GPA"));
                        a.Text = my_id.ToString();
                        b.Text = first;
                        c.Text = last;
                        d.Text = fac;
                        f.Text = add;
                        g.Text = type1;
                        h.Text = em;
                        i.Text = gpa.ToString();
                        j.Text = "           ";
                    }
                    conn.Close();
                }


            }
        }


        protected void list(object sender, EventArgs e)
        {
            Response.Redirect("MyTheses.aspx");
        }

        protected void view(object sender, EventArgs e)
        {
            Response.Redirect("ViewCourses.aspx");
        }

        protected void addReport(object sender, EventArgs e)
        {
            Response.Redirect("ProgressReports.aspx");
        }

        protected void addpub(object sender, EventArgs e)
        {
            Response.Redirect("AddPublication.aspx");
        }

        protected void linkpub(object sender, EventArgs e)
        {
            Response.Redirect("LinkPublication.aspx");
        }
    }
}


        
