using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeCoreLib;

public partial class _Default : System.Web.UI.Page
{
    private DepartmentRepository _deptRepository = new DepartmentRepository();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (checkSession())
        {
            deptHeading.InnerHtml = "This is the department page " + Session["user"];
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (txtDeptNo.Text != "" && txtDeptName.Text != "" && txtDeptLocation.Text != "")
        {
            _deptRepository.AddDepartment(Convert.ToInt32(txtDeptNo.Text), txtDeptName.Text, txtDeptLocation.Text);
        }
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        gridViewDepartment.DataSource = _deptRepository.Departments;
        gridViewDepartment.DataBind();
    }

    private Boolean checkSession()
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx?RedirectTo=Department.aspx");
            return false;
        }
        return true;
    }
}