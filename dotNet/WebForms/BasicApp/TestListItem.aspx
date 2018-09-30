<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestListItem.aspx.cs" Inherits="TestListItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblName" runat="server" Text="Enter Name:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <br />
        <br />
        <br />
    
    </div>
        <asp:ListBox ID="lstNames" runat="server" Height="221px" Width="267px"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
    </form>
</body>
</html>
