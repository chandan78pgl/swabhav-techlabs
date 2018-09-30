using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestQueryString : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["deptNo"]!=null)
        {
            string deptNo = Request.QueryString["deptNo"];
            deptDisplay.InnerHtml = "Displaying Records of Department = " + deptNo;
        }
        else
        {
            deptDisplay.InnerHtml = "No records to display";
        }
        
    }
}