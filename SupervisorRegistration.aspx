<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupervisorRegistration.aspx.cs" Inherits="PostGradOfficeeeweb.SupervisorRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Register<br />
        <br />
        FirstName<br />
        <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
        <br />
        LastName<br />
        <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
        <br />
        Password<br />
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
        <br />
        <br />
        Faculty<br />
        <asp:TextBox ID="faculty" runat="server"></asp:TextBox>
        <br />
        <br />
        Email<br />
        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="supervisorRegister" runat="server" Text="Register" OnClick="Button1_Click" />
    </form>
</body>
</html>
