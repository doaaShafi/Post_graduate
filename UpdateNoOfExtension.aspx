<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateNoOfExtension.aspx.cs" Inherits="PostGradOfficeeeweb.UpdateNoOfExtension" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Updating Number Of  Thesis Extensions "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Thesis Serial Number"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="ThesisSerialNO" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="updatenoofExtensions" runat="server" Text="Update" OnClick="updatenoofExtensions_Click" />
            <br />
            <br />
            <asp:Button ID="backtoAdminPage" runat="server" Text="Return to Main Page" OnClick="backtoAdminPage_Click" />
            <br />
        </div>
    </form>
</body>
</html>
