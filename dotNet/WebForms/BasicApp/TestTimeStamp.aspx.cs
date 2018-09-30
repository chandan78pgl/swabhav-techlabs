using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestTimeStamp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TimeStamp.BorderColor = Color.Red;
        TimeStamp1.BorderColor = Color.Blue;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {

    }
}