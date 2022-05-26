<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FillReport.aspx.cs" Inherits="MyApp.FillReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your Thesis Serial Number<br />
            <asp:TextBox ID="serialno" runat="server"></asp:TextBox>
            <br />
            Enter Report Number<br />
            <asp:TextBox ID="reportno" runat="server"></asp:TextBox>
            <br />
            Enter State<br />
            <asp:TextBox ID="state" runat="server"></asp:TextBox>
            <br />
            Enter Description<br />
            <asp:TextBox ID="desc" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="fill" runat="server" OnClick="report" Text="Fill" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
