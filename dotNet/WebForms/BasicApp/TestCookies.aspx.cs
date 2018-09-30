using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestCookies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }

    protected void btnSetCookie_Click(object sender, EventArgs e)
    {
        
        Response.Cookies["colorCookie"].Value = "Green";
        Response.Cookies["colorCookie"].Expires = DateTime.Now.AddSeconds(10);
    }

    protected void btnGetCookie_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["colorCookie"]!=null)
        {
            displayCookie.InnerHtml = "Cookie is the " + Request.Cookies["colorCookie"].Value;
            displayCookie.Style["background-color"] = Request.Cookies["colorCookie"].Value;
        }
        else
        {
            displayCookie.InnerHtml = "No Cookies Found Named Color";
            displayCookie.Style["background-color"] = "none";
        }
    }
}