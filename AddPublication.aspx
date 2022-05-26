<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddPublication.aspx.cs" Inherits="MyApp.AddPublication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            Enter Publication Title
        <br />
            <asp:TextBox ID="a" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Publicarion Host<br />
            <asp:TextBox ID="b" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Publication Place<br />
            <asp:TextBox ID="c" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Publication Date<br />
            <asp:TextBox ID="d" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Accepted<br />
            <asp:TextBox ID="f" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <br />
        </div>
       
    </form>
</body>
</html>
