<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProgressReports.aspx.cs" Inherits="MyApp.ProgressReports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="add" runat="server" Text="Add Progress Reports" OnClick="add_Click" />
            <br />
            <br />
            <asp:Button ID="fill" runat="server" Text="Fill Progress Reports" OnClick="fill_Click" Width="192px" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
