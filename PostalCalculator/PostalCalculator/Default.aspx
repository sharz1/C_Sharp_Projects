<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PostalCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Postal Calculator</h2>
            <br />
            Width:
            <asp:TextBox ID="WidthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
            <br />
            Height:
            <asp:TextBox ID="HeightTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
            <br />
            Length:
            <asp:TextBox ID="LengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="GroundRadioBtn" runat="server" GroupName="ShipSpeed" Text="Ground" OnCheckedChanged="handleChange" AutoPostBack="True" />
            <br />
            <asp:RadioButton ID="AirRadioBtn" runat="server" GroupName="ShipSpeed" Text="Air" OnCheckedChanged="handleChange" AutoPostBack="True" />
            <br />
            <asp:RadioButton ID="NextDayRadioBtn" runat="server" GroupName="ShipSpeed" Text="Next Day" OnCheckedChanged="handleChange" AutoPostBack="True" />
            <br />
            <br />
        </div>
        <asp:Label ID="PriceLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
