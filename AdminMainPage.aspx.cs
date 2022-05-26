using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostGradOfficeeeweb
{
    public partial class AdminMainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListSuperVisorButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("allSupervisors.aspx");
        }

        protected void ListAllThesesButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListAllTheses.aspx");
        }

        protected void CountThesesButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CountofOngoingTheses.aspx");
        }

        protected void IssueaThesisPaymentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssueaThesisPayment.aspx");

        }

        protected void IssueInstallmentsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssueInstallments.aspx");
        }

        protected void UpdateTheNumberOfThesisExtension_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateNoOfExtension.aspx");
        }

        protected void Logoutbutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

        }
    }
}