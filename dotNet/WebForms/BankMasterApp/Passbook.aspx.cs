using BankCoreLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private List<BankTransaction> _transactions = new List<BankTransaction>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (checkSession())
        {
            displayHeading.InnerHtml = "This is the Passbook Page = " + Session["account"];
            Transaction transaction = new Transaction();
            AccountHolder account = Session["AccountHolder"] as AccountHolder;

            _transactions= transaction.GetTransactionsByAccountNo(account);
            GridViewTransactions.DataSource = _transactions;
            GridViewTransactions.DataBind();
        }
    }

    protected void btnDownload_Click(object sender, EventArgs e)
    {
        DownloadAsCSV(_transactions);
    }

    private void DownloadAsCSV(List<BankTransaction> transactions)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(GridViewTransactions.HeaderRow.Cells[0].Text + ',');
        sb.Append(GridViewTransactions.HeaderRow.Cells[1].Text + ',');
        sb.Append(GridViewTransactions.HeaderRow.Cells[2].Text + ',');
        sb.Append(GridViewTransactions.HeaderRow.Cells[3].Text + ',');
        sb.Append("\r\n");

        foreach (var row in transactions)
        {
            sb.Append(row.AccountNo+",");
            sb.Append(row.Type+",");
            sb.Append(row.Amount+",");
            sb.Append(row.TransactionDate+",");
            sb.Append("\r\n");
        }

        File.WriteAllText(@"C:\Users\mahar\Downloads\Transactions.csv", sb.ToString());
    }

    private Boolean checkSession()
    {
        if (Session["account"] == null)
        {
            Response.Redirect("Login.aspx?RedirectTo=Passbook.aspx");
            return false;
        }
        return true;
    }
}