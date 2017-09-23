<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DartsGameSimulator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Dart Game Simulator</title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            text-decoration: underline;
            font-size: large;
        }
        .auto-style3 {
            text-decoration: underline;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="dartboardImage" runat="server" Height="500px" ImageAlign="Right" ImageUrl="dartboard.jpeg" />
            <span class="auto-style1"><span class="auto-style3"><strong>
            <br />
            <asp:Button ID="PlayButton" runat="server" OnClick="Button1_Click" Text="Play!" />
            <br />
            <br />
            Player 1 
            <br />
            </strong>
            <asp:TextBox ID="P1TextBox" runat="server"></asp:TextBox>
            <br />
            </span> </span>
            <asp:Label ID="p1nameLabel" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
            <asp:Label ID="player1Label" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <span class="auto-style2"><strong>Player 2<br />
            </strong>
            <asp:TextBox ID="P2TextBox" runat="server"></asp:TextBox>
            <br />
            </span>
            <asp:Label ID="p2nameLabel" runat="server"></asp:Label>
            <br />
            <asp:Label ID="player2Label" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
    </form>
</body>
</html>
