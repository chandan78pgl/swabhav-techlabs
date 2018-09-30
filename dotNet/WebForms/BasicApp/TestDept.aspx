<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestDept.aspx.cs" Inherits="TestDept" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblSelectDept" runat="server" Text="Select Department: "></asp:Label>
        <asp:DropDownList ID="dropDownListDept" runat="server" OnSelectedIndexChanged="deptDropDownList_Changed" AutoPostBack="True">
        </asp:DropDownList>
    
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
    
    </div>
        <div runat="server" id="displayDiv">
            
            <asp:GridView ID="gridViewEmployee" runat="server" EnableViewState="False">
            </asp:GridView>
            
        </div>
    </form>
</body>
</html>
