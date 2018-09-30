<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestCookies.aspx.cs" Inherits="TestCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 id="displayCookie" runat="server">
            
        </h1>
        <asp:Button ID="btnSetCookie" runat="server" OnClick="btnSetCookie_Click" Text="Set Cookie" />
        <asp:Button ID="btnGetCookie" runat="server" OnClick="btnGetCookie_Click" Text="Get Cookie" />
    </div>
    </form>
</body>
</html>
