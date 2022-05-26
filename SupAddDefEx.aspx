<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupAddDefEx.aspx.cs" Inherits="PostGradOfficeeeweb.SupAddDefEx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 644px">
    <form id="form1" runat="server">
        <div style="height: 653px">
            <br />
            <asp:Label ID="Label1" runat="server" Text="Add Defense for Thesis"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Return to Main Page" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Thesis Serial Number"></asp:Label>
            <br />
            <asp:TextBox ID="ThSrNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Defense Date"></asp:Label>
            <br />
            <asp:TextBox ID="DefDate" runat="server"></asp:TextBox>
            &nbsp;<asp:Label ID="Label13" runat="server" Text="Format: YYYY-MM-DD"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Defense Location"></asp:Label>
            <br />
            <asp:TextBox ID="DefLoc" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Label ID="Label10" runat="server" Text="(needed for adding defense only) "></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Add Examiner"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Examiner Name"></asp:Label>
            <br />
            <asp:TextBox ID="ExaminerName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="National"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Answer with 'yes' or 'no'"></asp:Label>
            <br />
            <asp:TextBox ID="National" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Field of Work"></asp:Label>
            <br />
            <asp:TextBox ID="Field" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="Pass" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="DefenseGucian" runat="server" Text="Add Defense for Gucian" OnClick="DefenseGucian_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="DefenseNonGucian" runat="server" Text="Add Defense for Non-Gucian" Width="206px" OnClick="DefenseNonGucian_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ExaminerforDefense" runat="server" Text="Add Examiner" Width="205px" OnClick="ExaminerforDefense_Click" />
            <br />
        </div>
    </form>
</body>
</html>
