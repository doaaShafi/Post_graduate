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
    public partial class SupViewPublication2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);



            SqlCommand pub = new SqlCommand("ViewAStudentPublications", conn);
            pub.CommandType = CommandType.StoredProcedure;

            int id = int.Parse(Session["studentID"].ToString());
            pub.Parameters.Add(new SqlParameter("@StudentID", id));

            conn.Open();
            SqlDataReader rdr = pub.ExecuteReader(CommandBehavior.CloseConnection);
            int i = 1;
            while (rdr.Read())
            {
                String PTitle = rdr.GetString(rdr.GetOrdinal("title"));
                DateTime Pdate = rdr.GetDateTime(rdr.GetOrdinal("dateOfPublication"));
                int Pid = rdr.GetInt32(rdr.GetOrdinal("id"));
                String Pplace = rdr.GetString(rdr.GetOrdinal("place"));
                String Phost = rdr.GetString(rdr.GetOrdinal("host"));
                bool Pacc = rdr.GetBoolean(rdr.GetOrdinal("accepted"));


                Label T = new Label();
                Label D = new Label();
                Label ID = new Label();
                Label p = new Label();
                Label h = new Label();
                Label a = new Label();



                ID.Text = "" + i + ".   id:  " + Pid.ToString() + "&nbsp; ";
                T.Text = " Title:     " + PTitle + "&nbsp; ";
                D.Text = "    Date:     " + Pdate.ToString() + "&nbsp; ";
                p.Text = "    Place:     " + Pplace + "&nbsp; ";
                a.Text = "    Accepted:     " + Pacc + "&nbsp; ";
                h.Text = "    Host:     " + Phost + "<br >";


                i++;
                form1.Controls.Add(ID);
                form1.Controls.Add(T);
                form1.Controls.Add(D);
                form1.Controls.Add(p);
                form1.Controls.Add(a);
                form1.Controls.Add(h);


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