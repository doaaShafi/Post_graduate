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
    public partial class LinkPublication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void link1(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand add = new SqlCommand("linkPubThesis", conn);
            add.CommandType = CommandType.StoredProcedure;

            SqlCommand check = new SqlCommand("isItYou", conn);
            check.CommandType = CommandType.StoredProcedure;

            SqlCommand key = new SqlCommand("check1", conn);
            key.CommandType = CommandType.StoredProcedure;

            



            if (Session["user"] != null)
            {
                int id = (int)Session["user"];
                if (string.IsNullOrEmpty(a.Text) || string.IsNullOrEmpty(b.Text))
                {
                    Response.Write("Please Complete your Information");
                }
                else
                {
                    String serial = b.Text;
                    String pub = a.Text;
                    int ser = int.Parse(serial);
                    int pub1 = int.Parse(pub);

                    check.Parameters.Add(new SqlParameter("@studentID", id));
                    check.Parameters.Add(new SqlParameter("@serial", ser));
                    SqlParameter c = check.Parameters.Add("@success", SqlDbType.Bit);
                    c.Direction = ParameterDirection.Output;

                    add.Parameters.Add(new SqlParameter("@thesisSerialNo", ser));
                    add.Parameters.Add(new SqlParameter("@PubID", pub1));

                    key.Parameters.Add(new SqlParameter("@pubID", pub1));
                    key.Parameters.Add(new SqlParameter("@no", ser));
                    SqlParameter c1 = key.Parameters.Add("@c", SqlDbType.Bit);
                    c1.Direction = ParameterDirection.Output;
                    conn.Open();
                    key.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    check.ExecuteNonQuery();
                    conn.Close();
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
                            Response.Write("linked");
                        }
                    }
                    else
                    {
                        Response.Write("Please Enter Your Thesis");
                    }
                }
            }
        }
    }
    }
