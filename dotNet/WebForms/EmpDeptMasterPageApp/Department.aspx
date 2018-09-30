<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Department.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1 id="deptHeading" runat="server">This is the department page</h1>

    <div>

        <asp:Label ID="lblDeptNo" runat="server" Text="Enter Department No: "></asp:Label>
        

        <asp:TextBox ID="txtDeptNo" runat="server"></asp:TextBox>
        

        <br />
        <br />
        <asp:Label ID="lblDeptName" runat="server" Text="Enter Department Name: "></asp:Label>
        <asp:TextBox ID="txtDeptName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDeptLocation" runat="server" Text="Enter Department Location: "></asp:Label>
        <asp:TextBox ID="txtDeptLocation" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display" />
        <br />
        <br />

    </div>
    <div runat="server" id="displayDiv">

        <asp:GridView ID="gridViewDepartment" runat="server" EnableViewState="False">
        </asp:GridView>

    </div>

</asp:Content>

