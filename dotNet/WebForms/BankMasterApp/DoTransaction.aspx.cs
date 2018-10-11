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
        if (checkSession())
        {
            displayHeading.InnerHtml = "This is the DoTransaction Page = " + Session["account"];
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Transaction bankTransaction = new Transaction();
        AccountHolder account = Session["AccountHolder"] as AccountHolder;
        bankTransaction.DoTransaction(account, RadioButtonListType.SelectedValue, Convert.ToInt32(txtAmount.Text));
    }

    private Boolean checkSession()
    {
        if (Session["account"] == null)
        {
            Response.Redirect("Login.aspx?RedirectTo=DoTransaction.aspx");
            return false;
        }
        return true;
    }
}