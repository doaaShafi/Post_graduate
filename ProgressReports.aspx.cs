using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyApp
{
    public partial class ProgressReports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void add_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddReport.aspx");
        }

        protected void fill_Click(object sender, EventArgs e)
        {
            Response.Redirect("FillReport.aspx");
        }
    }
}