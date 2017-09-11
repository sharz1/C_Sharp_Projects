<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>
                <asp:Image ID="Image1" runat="server" CssClass="auto-style1" Height="150px" ImageUrl="epic-spies-logo.jpg" />
                <br class="auto-style1" />
                <br class="auto-style1" />
                <span class="auto-style1">Asset Performance Tracker</span></h3>
            <p>
                Asset Name:
                <asp:TextBox ID="assetNameTextBox" runat="server" Height="16px"></asp:TextBox>
            </p>
            <p>
                Elections Rigged:
                <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                Acts of Subterfuge Performed:
                <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="addassetButton" runat="server" OnClick="addassetButton_Click" Text="Add Asset" />
            </p>
            <p>
                <asp:Label ID="assetdataLabel" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
