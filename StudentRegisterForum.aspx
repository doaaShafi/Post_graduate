<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegisterForum.aspx.cs" Inherits="PostGradOfficeeeweb.StudentRegisterForum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Registeration<br />
            <br />
            First Name<br />
            <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
            <br />
            Last Name<br />
            <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
            <br />
            Password<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            Faculty<br />
            <asp:TextBox ID="faculty" runat="server"></asp:TextBox>
            <br />
            Email<br />
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            Address<br />
            <asp:TextBox ID="Address" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="GUCIAN" runat="server" Height="28px"  Text="Register AS GUCian " Width="226px" OnClick="GUCIAN_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="NonGucian" runat="server" Text="Register AS Non-GUCian " OnClick="NonGucian_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
