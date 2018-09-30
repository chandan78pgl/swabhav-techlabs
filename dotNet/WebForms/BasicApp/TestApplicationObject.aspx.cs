using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestApplicationObject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Application["counter"] == null)
        {
            Application.Add("username", "chandan");
            Application.Add("counter", 0);
        }
        SetDisplay();
    }

    private void SetDisplay()
    {
        displayOldApplicationValue.InnerHtml = "User: " + Application["username"] + " Old: " + Application["counter"];
        Application["counter"] = Convert.ToInt32(Application["counter"]) + 1;
        displayNewApplicationValue.InnerHtml = "User: " + Application["username"] + " Old: " + Application["counter"];
    }
}