using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeCoreLib;

public partial class _Default : System.Web.UI.Page
{
    private EmployeeRepository _empRepository = new EmployeeRepository();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (checkSession())
        {
            empHeading.InnerHtml = "This is the Employee page " + Session["user"];
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        int empNo = Convert.ToInt32(txtEmpNo.Text);
        string empName = txtEmpName.Text;
        string empJob = txtEmpJob.Text;
        string empMGR = txtEmpMGR.Text;
        string empHireDate = txtEmpHireDate.Text;
        int empSalary = Convert.ToInt32(txtEmpSalary.Text);
        int empComm = Convert.ToInt32(txtEmpCOMM.Text);
        int empDeptNo = Convert.ToInt32(txtEmpDeptNo.Text);
        
        if (txtEmpName.Text != "")
        {
            _empRepository.AddEmployee(empNo, empName, empJob, empMGR, empHireDate, empSalary, empComm, empDeptNo);
        }
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        gridViewEmployee.DataSource = _empRepository.Employees;
        gridViewEmployee.DataBind();
    }
    private Boolean checkSession()
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx?RedirectTo=Employee.aspx");
            return false;
        }
        return true;
    }
}