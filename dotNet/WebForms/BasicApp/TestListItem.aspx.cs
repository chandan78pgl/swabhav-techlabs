using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestListItem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lstNames.Items.Add("Hitech");
            lstNames.Items.Add("Swabhav");
            lstNames.Items.Add("Techlabs");
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        lstNames.Items.Add(txtName.Text);
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        lstNames.Items.Remove(lstNames.SelectedItem);
    }

    
}