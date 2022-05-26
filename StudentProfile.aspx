<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentProfile.aspx.cs" Inherits="MyApp.StudentProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="a" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="b" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="c" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="d" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="f" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="g" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="h" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="i" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="j" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="thesis" runat="server" Text="View My Theses" OnClick="list" />

            <br />

            <br />
            <asp:Button ID="course" runat="server" OnClick="view" Text="View My Courses" />

            <br />
            <br />
            <asp:Button ID="Button1" runat="server"  OnClick="addReport" Text="My Progress Report" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server"  OnClick="addpub" Text="Add A Publication" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server"  OnClick="linkpub" Text="Link A Publication To My Thesis" />
        </div>
    </form>
</body>
</html>
