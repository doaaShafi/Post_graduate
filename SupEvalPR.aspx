<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupEvalPR.aspx.cs" Inherits="PostGradOfficeeeweb.SupEvalPR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 380px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Evaluating A Progress Report"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Return" runat="server" Text="Return To Main Page" Height="28px" OnClick="Return_Click" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Thesis Serial Number"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="ThesisSerialNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Progress Report Number"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="PRNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Evaluation"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="Eval" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Give an Evaluation Between 0 to 3"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Evaluate" Width="85px" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
