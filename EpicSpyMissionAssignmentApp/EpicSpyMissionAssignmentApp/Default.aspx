<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EpicSpyMissionAssignmentApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Arial Narrow";
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="epic-spies-logo.jpg" />
        </div>
        <h1 class="auto-style1">Spy New Assignment Form</h1>
        <p class="auto-style1">
            <strong>Spy Code Name:
            </strong>
            <asp:TextBox ID="spyNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <strong>New Assignment Name:</strong>
            <asp:TextBox ID="newassignTextBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            End Date of Previous Assignment:</p>
        <p class="auto-style1">
            <asp:Calendar ID="prevCalendar" runat="server" BackColor="White" BorderColor="#333333" BorderWidth="1px" Font-Names="Perpetua Titling MT" Font-Size="9pt" ForeColor="Black" Height="134px" NextPrevFormat="FullMonth" Width="142px">
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
            Start Date of New Assignment:</p>
        <asp:Calendar ID="newstartCalendar" runat="server" BackColor="White" BorderColor="#333333" BorderWidth="1px" Font-Names="Perpetua Titling MT" Font-Size="9pt" ForeColor="Black" Height="134px" NextPrevFormat="FullMonth" Width="142px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <DayStyle BorderStyle="Inset" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="Black" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333333" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <span class="auto-style1">Projected End Date of New Assignment:</span><br />
        <asp:Calendar ID="newendCalendar" runat="server" BackColor="White" BorderColor="#333333" BorderWidth="1px" Font-Names="Perpetua Titling MT" Font-Size="9pt" ForeColor="Black" Height="130px" NextPrevFormat="FullMonth" Width="101px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <DayStyle BorderStyle="Inset" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="Black" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333333" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <p class="auto-style1">
            <asp:Button ID="aspyButton" runat="server" OnClick="aspyButton_Click" Text="Assign Spy" />
        </p>
        <p class="auto-style1">
            <asp:Label ID="budgetLabel" runat="server" Font-Bold="True" Font-Names="Arial Narrow" Font-Size="Large"></asp:Label>
        </p>
    </form>
</body>
</html>
