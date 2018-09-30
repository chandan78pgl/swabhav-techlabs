<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestTimeStamp.aspx.cs" Inherits="TestTimeStamp" %>

<%@ Register Src="~/TimeStamp.ascx" TagPrefix="uc1" TagName="TimeStamp" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            <uc1:TimeStamp runat="server" ID="TimeStamp" />
        </div>
        <br />

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                <br />
                <br />
                <uc1:TimeStamp ID="TimeStamp2" runat="server" />
            </ContentTemplate>
            
        </asp:UpdatePanel>

        <br />
        <div>
            <uc1:TimeStamp runat="server" ID="TimeStamp1" />
        </div>
    </form>
</body>
</html>
