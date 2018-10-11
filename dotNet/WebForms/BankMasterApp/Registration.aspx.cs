using BankCoreLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["account"]!=null)
        {
            Session.Abandon();
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        int accountNo = Convert.ToInt32(txtAccountNo.Text);
        string name = txtAccountName.Text;
        float balance = Convert.ToSingle(txtBalance.Text);
        string password = txtPassword.Text;

        AccountHolder account = new AccountHolder { AccountNo = accountNo, Name = name, Balance = balance };
        Transaction transaction = new Transaction();
        transaction.RegisterNewUser(account, password);

        Response.Redirect("Home.aspx");
    }
}