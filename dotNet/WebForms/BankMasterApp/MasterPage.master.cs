using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["account"] != null)
        {
            Menu1.Items[4].Text = "Logout";
            Menu1.Items[4].NavigateUrl = "~/Login.aspx?id=logout";
        }

        
    }
}
