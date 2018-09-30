<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        height: 26px;
    }
    .auto-style2 {
        width: 138px;
    }
    .auto-style3 {
        height: 26px;
        width: 138px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 id="loginHeading" runat="server">This is the Login Page</h1>
    <div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblUserName" runat="server" Text="Username: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>

