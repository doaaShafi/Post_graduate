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
    public partial class SupListStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand students = new SqlCommand("ViewSupStudentsYears", conn);
            students.CommandType = CommandType.StoredProcedure;

            int id =int.Parse (Session["user"].ToString());
            students.Parameters.Add(new SqlParameter("@supervisorID", id));


            conn.Open();
            SqlDataReader rdr = students.ExecuteReader(CommandBehavior.CloseConnection);
            int i = 1;
            while (rdr.Read())
            {
                String studentsFNames = rdr.GetString(rdr.GetOrdinal("firstName"));
                String studentsLNames = rdr.GetString(rdr.GetOrdinal("lastName"));
                int studentsYears = rdr.GetInt32(rdr.GetOrdinal("years"));


                Label FName = new Label();
                Label LName = new Label();
                Label Year = new Label();

                FName.Text = ""+ i + ".   Name:  " +studentsFNames + "&nbsp; ";            
                LName.Text = studentsLNames + "&nbsp; " + "Years:  ";
                Year.Text = studentsYears.ToString() + " <br > ";
                i++;
                form1.Controls.Add(FName);
                form1.Controls.Add(LName);
                form1.Controls.Add(Year);
        
                
            }
     }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("Supervisor.aspx");
        }
    }
}