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
    public partial class allSupervisors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand listSupervisors = new SqlCommand("AdminListSup", conn);
            listSupervisors.CommandType = CommandType.StoredProcedure;
            conn.Open();

            String header = "id" + "  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + "email" + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "name" + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + "faculty";
            Label headers = new Label();
            headers.Text = header + "<br >";
            form1.Controls.Add(headers);


            SqlDataReader rdr = listSupervisors.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
               // String id = rdr.GetOrdinal("id").ToString();
                String SupervisorData =rdr.GetInt32(rdr.GetOrdinal("id"))+"&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  "+rdr.GetString(rdr.GetOrdinal("email")) + 
                    " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + rdr.GetString(rdr.GetOrdinal("name")) + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + rdr.GetString(rdr.GetOrdinal("faculty"));

                Label Supervisor = new Label();
                Supervisor.Text = SupervisorData + "<br >";
                form1.Controls.Add(Supervisor);
            }
            /*Button logout = new Button();
            logout.Text = "Log Out";
            form1.Controls.Add(logout);*/

            //" &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " -->means non-breaking space to insert a space in a label text
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMainPage.aspx");
        }
    }
}