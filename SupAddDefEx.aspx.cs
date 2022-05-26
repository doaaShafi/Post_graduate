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
    public partial class SupAddDefEx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ExaminerforDefense_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String ThesisSerialNo = ThSrNo.Text;
            DateTime DefenseDate = DateTime.Parse(DefDate.Text);
            String ExaminerName1 = ExaminerName.Text;
            String N = National.Text;
            String fieldOfWork = Field.Text;
            String Password = Pass.Text;

            if (string.IsNullOrEmpty(ThSrNo.Text) || string.IsNullOrEmpty(DefDate.Text) 
                || string.IsNullOrEmpty(ExaminerName.Text) || string.IsNullOrEmpty(National.Text)
                || string.IsNullOrEmpty(Field.Text) || string.IsNullOrEmpty(Pass.Text))
            {
                Response.Write("Please fill the required fields");
            }
            else
            {
                if(!(N.ToLower()=="no") && !(N.ToLower()=="yes"))
                {
                    Response.Write("Please Answer with 'yes' or 'no' in National");

                }
                else
                {
                    bool nationality;
                    if (N.ToLower() == "no")
                        nationality = false;
                    else
                        nationality = true;


                    SqlCommand addEx = new SqlCommand("AddExaminer", conn);
                    addEx.CommandType = CommandType.StoredProcedure;

                    addEx.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                    addEx.Parameters.Add(new SqlParameter("@DefenseDate", DefenseDate));
                    addEx.Parameters.Add(new SqlParameter("@ExaminerName", ExaminerName1));
                    addEx.Parameters.Add(new SqlParameter("@National", nationality));
                    addEx.Parameters.Add(new SqlParameter("@fieldOfWork", fieldOfWork));
                    addEx.Parameters.Add(new SqlParameter("@Password", Password));
                    

                    conn.Open();
                    try
                    {
                        addEx.ExecuteNonQuery();
                        Response.Write("Adding Examiner was Successful!");

                    }
                    catch
                    {
                        Response.Write("Invalid Data, Please try again with the correct data");

                    }
                    conn.Close();



                }
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            Response.Redirect("Supervisor.aspx");

        }

        protected void DefenseGucian_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String ThesisSerialNo = ThSrNo.Text;
            String DefenseDate = DefDate.Text;
            String DefenseLoc = DefLoc.Text;

            if (string.IsNullOrEmpty(ThSrNo.Text) || string.IsNullOrEmpty(DefDate.Text)
                || string.IsNullOrEmpty(DefLoc.Text) )
            {
                Response.Write("Please fill the required fields");
            }
            else
            {
                SqlCommand addDefG = new SqlCommand("AddDefenseGucian", conn);
                addDefG.CommandType = CommandType.StoredProcedure;

                addDefG.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                addDefG.Parameters.Add(new SqlParameter("@DefenseDate", DefenseDate));
                addDefG.Parameters.Add(new SqlParameter("@DefenseLocation", DefenseLoc));
                

                conn.Open();
                try
                {
                    addDefG.ExecuteNonQuery();
                    Response.Write("Adding Defense for Gucian was Successful!");
                }
                catch
                {
                    Response.Write("Invalid Data, Please try again with the correct data");

                }
                conn.Close();

            }

        }

        protected void DefenseNonGucian_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["PostGrad"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String ThesisSerialNo = ThSrNo.Text;
            String DefenseDate = DefDate.Text;
            String DefenseLoc = DefLoc.Text;

            if (string.IsNullOrEmpty(ThSrNo.Text) || string.IsNullOrEmpty(DefDate.Text)
                || string.IsNullOrEmpty(DefLoc.Text))
            {
                Response.Write("Please fill the required fields");
            }
            else
            {
                SqlCommand addDefNonG = new SqlCommand("AddDefenseNonGucian", conn);
                addDefNonG.CommandType = CommandType.StoredProcedure;

                addDefNonG.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                addDefNonG.Parameters.Add(new SqlParameter("@DefenseDate", DefenseDate));
                addDefNonG.Parameters.Add(new SqlParameter("@DefenseLocation", DefenseLoc));

                SqlCommand checkgrade = new SqlCommand("checkGrade", conn);
                checkgrade.CommandType = CommandType.StoredProcedure;

                checkgrade.Parameters.Add(new SqlParameter("@ThesisSerialNo", ThesisSerialNo));
                SqlParameter gotValue = checkgrade.Parameters.Add("@value", SqlDbType.Bit);
                gotValue.Direction = ParameterDirection.Output;
                try
                {
                    conn.Open();
                    checkgrade.ExecuteNonQuery();
                    conn.Close();
                }
                catch
                {
                    Response.Write("Invalid Data, Please try again with the correct data");

                }
                if ((bool)gotValue.Value == true)
                {

                    conn.Open();
                    try
                    {
                        addDefNonG.ExecuteNonQuery();
                        Response.Write("Adding Defense for Non-Gucian was Successful!");

                    }
                    catch
                    {
                        Response.Write("Invalid Data, Please try again with the correct data");

                    }
                    conn.Close();
                } else
                {
                    Response.Write("Cannot Add Defense for this Non-Gucian Student, because some of their courses' grades are less than 50");

                }
            }

        }

    }
}