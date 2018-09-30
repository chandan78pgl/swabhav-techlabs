using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        displayUser.InnerHtml = "Welcome " + Session["username"];
    }

    protected void AddBtnClick(object sender, EventArgs e)
    {
        if(txtTask.Text!="")
        {
            lstTodoDisplay.Items.Add(txtTask.Text);
        }
    }
}