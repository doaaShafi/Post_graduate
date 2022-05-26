<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupCancelThesis.aspx.cs" Inherits="PostGradOfficeeeweb.SupCancelThesis" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Thesis Serial Number"></asp:Label>
        &nbsp;<br />
            <br />
            <asp:TextBox ID="ThesisSr" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Label2" runat="server" Text="Please Note: This will permanently delete the Thesis if the evaluation of the last progress report is 0. Are you sure?"></asp:Label>
        &nbsp;<br />
            <br />
            <asp:Button ID="CancelTh" runat="server" Text="Yes, Cancel Thesis" OnClick="CancelTh_Click" />
            &nbsp;&nbsp;<br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text=" Return to Main Page" Width="175px" OnClick="Button1_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
