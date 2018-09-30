
using System;
using System.Web.UI.HtmlControls;
using DepartmentLib;

public partial class TestDept : System.Web.UI.Page
{
    private DepartmentRepository _deptRepository;

    protected void Page_Load(object sender, EventArgs e)
    {
        _deptRepository = new DepartmentRepository();
        if (!IsPostBack)
        {
            dropDownListDept.DataSource = _deptRepository.GetDepartmentList();
            dropDownListDept.DataTextField = "DeptName";
            dropDownListDept.DataValueField = "DeptNo";
            dropDownListDept.DataBind();

            deptDropDownList_Changed(sender,e);
        }
        
    }

    protected void deptDropDownList_Changed(object sender, EventArgs e)
    {
        HtmlGenericControl displayTag = new HtmlGenericControl("h1");
        displayTag.InnerHtml = "Display Department Name: "+dropDownListDept.SelectedItem.ToString()+" & Dept_NO - "+dropDownListDept.SelectedItem.Value;
        displayDiv.Controls.Add(displayTag);

        gridViewEmployee.DataSource = _deptRepository.GetEmployees(Convert.ToInt32(dropDownListDept.SelectedItem.Value));
        gridViewEmployee.DataBind();
    }
}