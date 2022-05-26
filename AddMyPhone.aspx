<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMyPhone.aspx.cs" Inherits="PostGradOfficeeeweb.AddMyPhone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add your telephone number<br />
            <br />
            <asp:TextBox ID="addtelephone" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addbutton" runat="server" style="margin-bottom: 0px" Text="Add" OnClick="addtelephone_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
