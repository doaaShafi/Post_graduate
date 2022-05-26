<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="PostGradOfficeeeweb.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Who are you ?<br />
            <br />
            <asp:Button ID="Studentbutton" runat="server" Text="Student" OnClick="Studentbutton_Click" Width="130px" />
            <br />
            <br />
            <asp:Button ID="Supervisorbutton" runat="server" Text="Supervisor" OnClick="Supervisorbutton_Click" Width="129px" />
            <br />
            <br />
            <asp:Button ID="Examinerbutton" runat="server" Text="Examiner" OnClick="Examinerbutton_Click" Width="131px" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
