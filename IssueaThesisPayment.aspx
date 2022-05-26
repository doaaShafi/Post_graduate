<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IssueaThesisPayment.aspx.cs" Inherits="PostGradOfficeeeweb.IssueaThesisPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Issue a Thesis Payment"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Thesis SerialNo"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="serialNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="amount"></asp:Label>
            <br />
            <asp:TextBox ID="amount" runat="server"></asp:TextBox>
            <br />
            &nbsp;&nbsp;
            <br />
            <asp:Label ID="Label4" runat="server" Text="Number of Installments"></asp:Label>
            <br />
            <asp:TextBox ID="NumberofInstallements" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Fund Percentage"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="FundPercentage" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="IssuePayment" runat="server" Text="Submit" OnClick="IssuePayment_Click" />
            <br />
            <br />
            <asp:Button ID="BacktoAdminpage" runat="server" Text="Return to Main Page" OnClick="BacktoAdminpage_Click" />
            <br />
        </div>
    </form>
</body>
</html>
