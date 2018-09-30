using System.Web.UI;

public partial class WelcomeForm : Page
{
    public void Page_Load()
    {
        if (Page.IsPostBack)
        {
            lblMethod.Text = "POST METHOD IS FIRED";
        }
        else if(Request.HttpMethod=="GET")
        {
            lblMethod.Text = "GET METHOD IS FIRED";
        }
    }

    public void btnWishClick(object sender, System.EventArgs e)
    {
        if (txtName.Text!="")
        {
            lblDisplay.Text = "Hello, " + txtName.Text;
        }
    }
}