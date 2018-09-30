using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LoginCoreLib;
public partial class _Default : System.Web.UI.Page
{

    private LoginService _loginService = new LoginService();

    protected void Page_Load(object sender, EventArgs e)
    {
        loginHeading.InnerHtml = "This is the Login Page From " + Request.QueryString["RedirectTo"];
        if (Request.QueryString["id"]=="logout")
        {
            Session.Abandon();
            Response.Redirect("Welcome.aspx");
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string userName = txtUsername.Text;
        string password = txtPassword.Text;

        if (_loginService.AuthenticateUser(userName,password))
        {
            Session["user"] = txtUsername.Text;
            Session.Timeout = 1;
            
            Response.Redirect(Request.QueryString["RedirectTo"]);
        }
    }
}