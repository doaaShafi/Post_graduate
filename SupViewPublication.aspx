<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupViewPublication.aspx.cs" Inherits="PostGradOfficeeeweb.SupViewPublication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 67px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Please Enter the ID of the Student you wish to view their Publications"></asp:Label>
        &nbsp;<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="proceed" runat="server" Text="Proceed" OnClick="proceed_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Cancel" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
