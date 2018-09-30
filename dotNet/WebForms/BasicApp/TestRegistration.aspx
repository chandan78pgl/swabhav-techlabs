<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestRegistration.aspx.cs" Inherits="TestRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 154px;
        }
        .auto-style3 {
            width: 122px;
        }
        .auto-style4 {
            width: 99%;
            height: 178px;
        }
        .auto-style5 {
            width: 35px;
        }
    </style>
</head>
<body style="width: 702px">
    <form id="form1" runat="server">
        <table class="auto-style4">
            <tr>
                <td colspan="3" style="font-family: 'Bahnschrift Light'; font-size: 23px; color: #800000; text-align: center">Registration Form</td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right; font-family: 'Century Gothic';">
                    <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
                </td>
                <td class="auto-style5" style="text-align: center">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3" style="text-align: center">
                    <asp:RequiredFieldValidator ID="RequiredNameFieldValidator" runat="server" ControlToValidate="txtName" ErrorMessage="Name Field is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right; font-family: 'Century Gothic';">
                    <asp:Label ID="lblAge" runat="server" Text="Age:"></asp:Label>
                </td>
                <td class="auto-style5" style="text-align: center">
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3" style="text-align: center">
                    <asp:RangeValidator ID="AgeRangeValidator" runat="server" ControlToValidate="txtAge" ErrorMessage="Age Must to 18 to 60" ForeColor="#FF9900" MaximumValue="60" MinimumValue="18" Type="Integer"></asp:RangeValidator><br />
                    <asp:RequiredFieldValidator ID="AgeRequiredFieldValidator" runat="server" ControlToValidate="txtAge" ErrorMessage="Age Field is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right; font-family: 'Century Gothic';">
                    <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
                </td>
                <td class="auto-style5" style="text-align: center">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3" style="text-align: center">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is Incorrect " ForeColor="#FF6600" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right; font-family: 'Century Gothic';">
                    <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
                </td>
                <td class="auto-style5" style="text-align: center">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3" style="text-align: center">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right; font-family: 'Century Gothic';">
                    <asp:Label ID="lblRetypePassword" runat="server" Text="Re-type Password: "></asp:Label>
                </td>
                <td class="auto-style5" style="text-align: center">
                    <asp:TextBox ID="txtRetypePassword" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3" style="text-align: center">
                    <asp:CompareValidator ID="RetypePasswordCompareValidator" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRetypePassword" ErrorMessage="Password Must Match" ForeColor="#FF6600"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="text-align: right; font-family: 'Century Gothic';">
                    <asp:Label ID="Salary" runat="server" Text="Salary: "></asp:Label>
                </td>
                <td class="auto-style5" style="text-align: center">
                    <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3" style="text-align: center">
                    <asp:CompareValidator ID="SalaryCompareValidator" runat="server" ControlToValidate="txtSalary" ErrorMessage="Salary Must Be Greater Than 10000" ForeColor="#FF6600" Operator="GreaterThan" Type="Double" ValueToCompare="10000"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
