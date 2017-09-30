<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WarCardGameSimulator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>War Card Game Simulator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Image ID="P1Image" runat="server" Height="150px" ImageUrl="Images/back.png" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="P2Image" runat="server" Height="150px" ImageUrl="Images/back.png" />
        </div>
        <p>
            Player1 <asp:TextBox ID="P1TextBox" runat="server"></asp:TextBox>
&nbsp; Player 2
            <asp:TextBox ID="P2TextBox" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="PlayButton" runat="server" OnClick="PlayButton_Click" Text="Play War!" />
        <br />
        <br />
        <asp:Label ID="ResultsLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
