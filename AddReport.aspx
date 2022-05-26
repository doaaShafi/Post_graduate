<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddReport.aspx.cs" Inherits="MyApp.AddReport" %>

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
            Enter Date<br />
            <asp:TextBox ID="date" runat="server"></asp:TextBox>
            <br />
            Enter Progress Report Number<br />
            <asp:TextBox ID="reportno" runat="server"></asp:TextBox>
            <br />
            
            <br />
            <asp:Button ID="add" runat="server" OnClick="report" Text="Add" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
