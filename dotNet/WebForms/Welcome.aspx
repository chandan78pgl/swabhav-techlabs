<%@Page Language="C#" CodeFile="Welcome.aspx.cs" Inherits="WelcomeForm"%>
<!Doctype html>

<html>
    <head>
        <title>Welcome Page</title>
    </head>
    <body>
        <h1>This is an Asp.net Welcome Page</h1>
        <asp:Label ID="lblMethod" runat="server"></asp:Label>
        <form runat="server">
            Enter Name: 
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="btnWish" runat="server" OnClick="btnWishClick" Text="Wish"/>
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
        </form>
    </body>
</html>