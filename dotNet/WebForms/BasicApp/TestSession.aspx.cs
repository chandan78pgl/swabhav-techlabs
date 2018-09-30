using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestSession : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["counter"] == null)
        {
            Session["counter"] = 0;
            Session.Timeout = 1;
        }
        setDisplay();
    }

    private void setDisplay()
    {
        displayOldSessionValue.InnerHtml = "Old value in session = " + Session["counter"];
        Session["counter"] = Convert.ToInt32(Session["counter"]) + 1;
        displayNewSessionValue.InnerHtml = "New value in session = " + Session["counter"] + "<br/> Session ID: " + Session.SessionID;
    }
}