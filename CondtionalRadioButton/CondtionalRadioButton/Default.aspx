<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CondtionalRadioButton.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your note taking preference<br />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="writingUtensils" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penRadioButton" runat="server" GroupName="writingUtensils"  Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="writingUtensils" Text="Phone" />
            <br />
            <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="writingUtensils" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Image ID="optionImage" runat="server" />
            <br />
            <br />
            <asp:Label ID="selectedLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
