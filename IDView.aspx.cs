using System;
using System.Web.UI;

namespace PostGradOfficeeeweb
{
    public partial class IDView : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var String=

        }

        protected void loginafterRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");

        }
    }
}