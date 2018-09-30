using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContactCore;

public partial class ContactPage : System.Web.UI.Page
{
    private ContactManager _contactManager;

    protected void Page_Load(object sender, EventArgs e)
    {
        _contactManager = new ContactManager();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (txtName.Text != "" && txtNumber.Text != "")
        {
            _contactManager.AddContact(txtName.Text,txtNumber.Text);
        }
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        gridViewContact.DataSource = _contactManager.Contacts;
        gridViewContact.DataBind();
    }
}