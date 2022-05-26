<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExaminerRegistration.aspx.cs" Inherits="PostGradOfficeeeweb.ExaminerRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Register<br />
            <br />
            Name<br />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            FieldOfWork<br />
            <asp:TextBox ID="FieldofWork" runat="server"></asp:TextBox>
            <br />
            isNational<br />
            <asp:TextBox ID="isNational" runat="server"></asp:TextBox>
            &nbsp;Put 1 if you are a national Examiner ,otherwise 0<br />
            Password<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            Email<br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="examinerRegister" runat="server" Text="Register" OnClick="examinerRegister_Click" />
            <br />
        </div>
    </form>
</body>
</html>
