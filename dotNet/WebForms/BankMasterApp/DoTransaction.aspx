<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DoTransaction.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 332px;
        }
        .auto-style2 {
            width: 174px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 id="displayHeading" runat="server">This is the DoTransaction Page</h1>
    <div>

        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblAmount" runat="server" Text="Transaction Amount: "></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblRadio" runat="server" Text="Select Type:"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:RadioButtonList ID="RadioButtonListType" runat="server" Width="119px" >
                        <asp:ListItem>Deposit</asp:ListItem>
                        <asp:ListItem>Withdraw</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>

