<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Helvetica;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sharlee&#39;s Simple Calculator</h1>
            <br />
            <span class="auto-style1">First Value</span>
            <asp:TextBox ID="inputBox1" runat="server"></asp:TextBox>
            <br />
            <span class="auto-style1">Second Value</span>
            <asp:TextBox ID="inputBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="plusButton" runat="server" Text="+" OnClick="plusButton_Click" />
            &nbsp;
            <asp:Button ID="minusButton" runat="server" Text="-" OnClick="minusButton_Click" />
            &nbsp;
            <asp:Button ID="multButton" runat="server" Text="*" OnClick="multButton_Click" />
            &nbsp;
            <asp:Button ID="divideButton" runat="server" Text="/" OnClick="divideButton_Click" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" BackColor="#33CCFF"></asp:Label>
        </div>
    </form>
</body>
</html>
