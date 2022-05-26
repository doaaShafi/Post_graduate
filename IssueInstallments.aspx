<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssueInstallments.aspx.cs" Inherits="PostGradOfficeeeweb.IssueInstallments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Issue Installment"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Payment ID"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="paymentid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Install Start Date"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="InstallStartDate" runat="server"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Text="Please Write it in this format : YYYY/MM/DD"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="IssueInstalllement" runat="server" Text="Submit" OnClick="IssueInstalllement_Click" />
            <br />
            <br />
            <asp:Button ID="BacktoAdminPage" runat="server" Text="Back to Main Page" OnClick="Button2_Click" />
            <br />
        </div>
    </form>
</body>
</html>
