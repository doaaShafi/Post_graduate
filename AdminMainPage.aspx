<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminMainPage.aspx.cs" Inherits="PostGradOfficeeeweb.AdminMainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            What do you want ?<br />
            <br />
            <asp:Button ID="ListSuperVisorButton" runat="server" Text="List All Supervisors" Width="290px" OnClick="ListSuperVisorButton_Click" />
            <br />
            <br />
            <asp:Button ID="ListAllThesesButton" runat="server" Text="List All Theses" Width="294px" OnClick="ListAllThesesButton_Click"  />
            <br />
            <br />
            <asp:Button ID="CountThesesButton" runat="server" Text="Count of On-going Theses" Width="296px" OnClick="CountThesesButton_Click" />
            <br />
            <br />
            <asp:Button ID="IssueaThesisPaymentButton" runat="server" Text="Issue a thesis payment" Width="300px" OnClick="IssueaThesisPaymentButton_Click" />
            <br />
            <br />
            <asp:Button ID="IssueInstallmentsButton" runat="server" Text="Issue installments" Width="305px" OnClick="IssueInstallmentsButton_Click" />
            <br />
            <br />
            <asp:Button ID="UpdateTheNumberOfThesisExtension" runat="server" Text="Update the number of thesis extension" Width="303px" OnClick="UpdateTheNumberOfThesisExtension_Click" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Logoutbutton" runat="server" Text="Log Out" OnClick="Logoutbutton_Click" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
