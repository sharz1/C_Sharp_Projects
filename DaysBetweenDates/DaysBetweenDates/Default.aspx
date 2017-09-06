<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DaysBetweenDates.Default" %>

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
        <div class="auto-style1">
            <h3>How many days have elapsed?</h3>
        </div>
        <p class="auto-style1">
            Choose first date:</p>
        <p>
            <asp:Calendar ID="firstCalendar" runat="server" BackColor="White" BorderColor="#333333" BorderWidth="1px" Font-Names="Perpetua Titling MT" Font-Size="9pt" ForeColor="Black" Height="115px" NextPrevFormat="FullMonth" Width="161px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <DayStyle BorderStyle="Inset" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="Black" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333333" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
        </p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            Choose second date:</p>
        <asp:Calendar ID="secondCalendar" runat="server" BackColor="White" BorderColor="#333333" BorderWidth="1px" Font-Names="Perpetua Titling MT" Font-Size="9pt" ForeColor="Black" Height="115px" NextPrevFormat="FullMonth" Width="161px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <DayStyle BorderStyle="Inset" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="Black" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333333" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <asp:Button ID="calcButton" runat="server" Font-Names="Tahoma" OnClick="calcButton_Click" Text="# of Days" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" Font-Size="Large"></asp:Label>
    </form>
</body>
</html>
