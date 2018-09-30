<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactPage.aspx.cs" Inherits="ContactPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Welcome to Contact Page</h1>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblNumber" runat="server" Text="Number: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="btnDisplay_Click" Text="Display" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="gridViewContact" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
