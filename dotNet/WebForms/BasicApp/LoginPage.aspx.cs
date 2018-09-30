using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string username = "chandan";
        string password = "root";

        if (username == txtUserName.Text && password==txtPassword.Text)
        {
            Session.Add("username", txtUserName.Text);
            Session.Timeout = 1;
            //Response.Redirect("Welcome.aspx");
            Server.Transfer("Welcome.aspx");
            Session.RemoveAll();
        }
    }
}