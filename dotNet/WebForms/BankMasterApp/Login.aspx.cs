using BankCoreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private LoginService _loginService = new LoginService();

    protected void Page_Load(object sender, EventArgs e)
    {
        loginHeading.InnerHtml = "This is the Login Page From " + Request.QueryString["RedirectTo"];
        if (Request.QueryString["id"] == "logout")
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        int userAccount = Convert.ToInt32(txtUserAccount.Text);
        string password = txtPassword.Text;

        if (_loginService.AuthenticateUser(userAccount, password))
        {
            Session["account"] = txtUserAccount.Text;
            Session["AccountHolder"] = _loginService.Account;
            Session.Timeout = 1;

            if (Request.QueryString["RedirectTo"]!=null)
            {
                Response.Redirect(Request.QueryString["RedirectTo"]);
            }
            Response.Redirect("Home.aspx");
        }
    }
}