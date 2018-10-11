<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Passbook.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 id="displayHeading" runat="server">This is the Passbook page</h1>
    <div>
        <asp:GridView ID="GridViewTransactions" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="btnDownload" runat="server" OnClick="btnDownload_Click" Text="Download" />
    </div>
</asp:Content>

