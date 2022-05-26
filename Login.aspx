<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PostGradOfficeeeweb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Login<br />
            <br />
            Email<br />
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            Password<br />
            <asp:TextBox ID="password" runat="server" type ="password"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="loginbutton" runat="server" OnClick="login" Text="LOGIN" />
            <br />
            <br />
            <asp:Button ID="needRegistartion" runat="server" Text="I need to Register" OnClick="needRegistartion_Click" />
        </div>
    </form>
</body>
</html>
