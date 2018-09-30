<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 id="displayUser" runat="server"></h1>
        <div>
            <asp:Label ID="lblTask" runat="server" Text="Task: "></asp:Label>
            <asp:TextBox ID="txtTask" runat="server"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="AddBtnClick" Text="Add"/>

            <div runat="server">
                <asp:BulletedList ID="lstTodoDisplay" runat="server" EnableViewState="false"></asp:BulletedList>
            </div>
        </div>
    </form>

</body>
</html>
