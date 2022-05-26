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
    public partial class MyTheses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand Proc = new SqlCommand("viewMyTheses", conn);
            Proc.CommandType = CommandType.StoredProcedure;

            if (Session["user"] != null)
            {
                int id = (int)Session["user"];
                Proc.Parameters.Add(new SqlParameter("@studentID", id));
                conn.Open();
                SqlDataReader reader = Proc.ExecuteReader();
                while (reader.Read())
                {
                    int ser = reader.GetInt32(reader.GetOrdinal("serialNumber"));
                    String fi = reader.GetString(reader.GetOrdinal("field"));
                    String ty = reader.GetString(reader.GetOrdinal("type"));
                    String ti = reader.GetString(reader.GetOrdinal("title"));
                    DateTime sd = reader.GetDateTime(reader.GetOrdinal("startDate"));
                    DateTime ed = reader.GetDateTime(reader.GetOrdinal("endDate"));
                    DateTime dd = reader.GetDateTime(reader.GetOrdinal("defenseDate"));
                    int y = reader.GetInt32(reader.GetOrdinal("years"));
                    decimal g = reader.GetDecimal(reader.GetOrdinal("grade"));
                    int num = reader.GetInt32(reader.GetOrdinal("noOfExtensions"));
                    String name = reader.GetString(reader.GetOrdinal("My supervisor"));
                    Label a = new Label();
                    a.Text = ser.ToString()+"<br>";
                    Label b = new Label();
                    b.Text = fi+"<br>";
                    Label c = new Label();
                    c.Text = ty + "<br>";
                    Label d = new Label();
                    d.Text = ti + "<br>";
                    Label f = new Label();
                    f.Text = sd.ToString() + "<br>";
                    Label k = new Label();
                    k.Text = ed.ToString() + "<br>";
                    Label h = new Label();
                    h.Text = dd.ToString() + "<br>";
                    Label i = new Label();
                    i.Text = y.ToString() + "<br>";
                    Label j = new Label();
                    j.Text = g.ToString() + "<br>";
                    Label l = new Label();
                    l.Text = num.ToString() + "<br>";
                    Label m = new Label();
                    m.Text = name + "<br>";
                    form1.Controls.Add(a);
                    form1.Controls.Add(b);
                    form1.Controls.Add(c);
                    form1.Controls.Add(d);
                    form1.Controls.Add(f);
                    form1.Controls.Add(k);
                    form1.Controls.Add(h);
                    form1.Controls.Add(i);
                    form1.Controls.Add(j);
                    form1.Controls.Add(l);
                    form1.Controls.Add(m);
                }

            }
        }
    }

}
    
