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
    public partial class ListAllTheses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand listAllTheses= new SqlCommand("AdminViewAllTheses", conn);
            listAllTheses.CommandType = CommandType.StoredProcedure;
            conn.Open();

            String header = "serialNumber" + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + "field" + " &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; " + "type" + "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  "  + "title" + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; " + "startDate" + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; " + "endDate" +
                "  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; " + "defenseDate" + " &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; " + "years" + " &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; " + 
                "grade" + "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  " + "payment_id" + " &nbsp; &nbsp; &nbsp; " + "noOfExtensions";
            Label headers = new Label();
            headers.Text = header + "<br >";
            form1.Controls.Add(headers);

            SqlDataReader rdr = listAllTheses.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read()) {
                String ThesisData = rdr.GetInt32(rdr.GetOrdinal("serialNumber"))+ "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + rdr.GetString(rdr.GetOrdinal("field")) + "&nbsp; &nbsp; &nbsp; &nbsp; " +  rdr.GetString(rdr.GetOrdinal("type")) + "&nbsp; &nbsp; &nbsp; &nbsp; " + rdr.GetString(rdr.GetOrdinal("title")) + "&nbsp; &nbsp; &nbsp; &nbsp; " + rdr.GetDateTime(rdr.GetOrdinal("startDate")) + "&nbsp; &nbsp; &nbsp; &nbsp; " + rdr.GetDateTime(rdr.GetOrdinal("endDate")) + "&nbsp; &nbsp; &nbsp; &nbsp; " + rdr.GetDateTime(rdr.GetOrdinal("defenseDate")) + "&nbsp; &nbsp; &nbsp; &nbsp; " + rdr.GetInt32(rdr.GetOrdinal("years")) + "&nbsp; &nbsp; &nbsp; &nbsp; "
                +    rdr.GetDecimal(rdr.GetOrdinal("grade")) + "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + rdr.GetInt32(rdr.GetOrdinal("payment_id")) + "&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + rdr.GetInt32(rdr.GetOrdinal("noOfExtensions"));
                Label Thesis = new Label();
                Thesis.Text = ThesisData + "<br >";
                form1.Controls.Add(Thesis);
                                     
             }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMainPage.aspx");

        }
    }
}