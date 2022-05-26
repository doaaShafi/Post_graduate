<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkPublication.aspx.cs" Inherits="MyApp.LinkPublication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add publication id<br />
            <br />
            <asp:TextBox ID="a" runat="server"></asp:TextBox>
            <br />
            <br />
            Add serial number<br />
            <br />
            <asp:TextBox ID="b" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="c" runat="server" style="margin-bottom: 0px" Text="Link" OnClick="link1" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
