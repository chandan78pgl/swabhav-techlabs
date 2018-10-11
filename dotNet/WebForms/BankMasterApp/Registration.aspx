<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            height: 26px;
            margin-left: 40px;
        }
        .auto-style3 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 id="displayHeading" runat="server">This is the Registration Page</h1>
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="lblAccountNo" runat="server" Text="Account No: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAccountNo" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="AccountNoValidator" runat="server" ControlToValidate="txtAccountNo" ErrorMessage="This Field is Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAccountName" runat="server" Text="Account Name:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAccountName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="NameValidator" runat="server" ControlToValidate="txtAccountName" ErrorMessage="This Field is Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblBalance" runat="server" Text="Balance: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBalance" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="BalanceValidator" runat="server" ControlToValidate="txtBalance" ErrorMessage="This Field is Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" ControlToValidate="txtPassword" ErrorMessage="This field is Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="lblRetypePassword" runat="server" Text="Retype Password: "></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtRetypePassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRetypePassword" ErrorMessage="Password Must Be Same"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

