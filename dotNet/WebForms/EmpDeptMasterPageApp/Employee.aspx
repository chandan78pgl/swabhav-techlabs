<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 269px;
        }
    .auto-style2 {
        width: 269px;
        height: 26px;
    }
    .auto-style3 {
        height: 26px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 id="empHeading" runat="server">This is Employee Page</h1>
    <div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblEmpNo" runat="server" Text="Employee No: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmpNo" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblEmpName" runat="server" Text="Employee Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmpName" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblEmpJob" runat="server" Text="Employee Job:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmpJob" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblEmpMGR" runat="server" Text="Employee Manager: "></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmpMGR" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblEmpHireDate" runat="server" Text="Employee HireDate: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmpHireDate" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblEmpSalary" runat="server" Text=" Employee Salary: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmpSalary" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblEmpCOMM" runat="server" Text="Employee Commission: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmpCOMM" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="lblDeptNo" runat="server" Text="Employee Department No: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmpDeptNo" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                    <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" />
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
    <div runat="server" id="displayDiv">

        <asp:GridView ID="gridViewEmployee" runat="server">
        </asp:GridView>

    </div>
</asp:Content>

