<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CasinoSlots.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="reel1" runat="server" Height="150px" ImageUrl="Plum.png" />
            <asp:Image ID="reel2" runat="server" Height="150px" ImageUrl="Clover.png" />
            <asp:Image ID="reel3" runat="server" Height="150px" ImageUrl="HorseShoe.png" />
        </div>
        <p class="auto-style2">
            Your Bet:</p>
        <p>
            <asp:RadioButton ID="Radio1" runat="server" Text="$1" GroupName="BetAmount" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Radio2" runat="server" Text="$2" GroupName="BetAmount" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Radio5" runat="server" Text="$5" GroupName="BetAmount" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Radio10" runat="server" Text="$10" GroupName="BetAmount" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="Radio20" runat="server" Text="MAXBET ($20)" GroupName="BetAmount" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioOther" runat="server" Text="Other: " GroupName="BetAmount" />
            <asp:TextBox ID="BetTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;<asp:Button ID="LeverBtn" runat="server" OnClick="LeverBtn_Click" Text="Pull The Lever!" />
        </p>
        <asp:Label ID="ResultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="MoneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="25px" ImageUrl="Cherry.png" style="margin-left: 0px" />
&nbsp;- Win 2X Your Bet<br />
        <strong>
        <asp:Image ID="Image2" runat="server" Height="25px" ImageUrl="Cherry.png" style="margin-left: 0px" />
        <asp:Image ID="Image3" runat="server" Height="25px" ImageUrl="Cherry.png" style="margin-left: 0px" />
        </strong> &nbsp;- Win 3X Your Bet<br />
        <strong>
        <asp:Image ID="Image4" runat="server" Height="25px" ImageUrl="Cherry.png" style="margin-left: 0px" />
        <asp:Image ID="Image5" runat="server" Height="25px" ImageUrl="Cherry.png" style="margin-left: 0px" />
        <asp:Image ID="Image6" runat="server" Height="25px" ImageUrl="Cherry.png" style="margin-left: 0px" />
        </strong>&nbsp;- Win 4X Your Bet<br />
        <br />
        <strong>
        <asp:Image ID="Image7" runat="server" Height="25px" ImageUrl="Seven.png" style="margin-left: 0px" />
        <asp:Image ID="Image8" runat="server" Height="25px" ImageUrl="Seven.png" style="margin-left: 0px" />
        <asp:Image ID="Image9" runat="server" Height="25px" ImageUrl="Seven.png" style="margin-left: 0px" />
        </strong>&nbsp;- Jackpot! - Win 100X Your Bet<br />
        <br />
        HOWEVER...  <br />
        <br />
       If there is even 1<strong><br />
        <asp:Image ID="Image10" runat="server" Height="47px" ImageUrl="Bar.png" style="margin-left: 0px" Width="49px" />
        </strong>&nbsp;<br />
        you win nothing.</form>
</body>
</html>
