<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 170px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td style="text-align: right">
                    <asp:Label ID="lblUserName" runat="server" Text="Username: "></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">
                    <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                </td>
                <td colspan="2">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
