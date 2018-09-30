using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestSummary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        setDisplay();   
    }

    private void setDisplay()
    {
        displayNewSessionValue.InnerHtml = "New Session Value = " + Session["counter"];
        displayNewApplicationValue.InnerHtml = "New Application Value = " + Application["counter"];
    }
}