using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TimeStamp : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTimeStamp.Text = DateTime.Now.ToString("hh:mm:ss");
    }

    public Color BorderColor
    {
        set
        {
            lblTimeStamp.BorderColor=value;
        }
        get
        {
            return lblTimeStamp.BorderColor;
        }
    }
}