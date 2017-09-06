<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstPapaBobsPizza.Default" %>

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
            <asp:Image ID="Image1" runat="server" ImageUrl="PapaBob.png" />
            <h1 style="width: 483px" class="auto-style1">Papa Bob&#39;s Pizza and Software</h1></div>
        <asp:RadioButton ID="babyRadio" runat="server" GroupName="pizzaSize" Text="Baby Bob Size (10&quot;) - $10" />
        <br />
        <asp:RadioButton ID="mamaRadio" runat="server" GroupName="pizzaSize" Text="Mama Bob Size (13&quot;) - $13" />
        <br />
        <asp:RadioButton ID="papaRadio" runat="server" GroupName="pizzaSize" Text="Papa Bob Size (16&quot;) - $16" Checked="True" />
        <br />
        <br />
        <asp:RadioButton ID="thinRadio" runat="server" GroupName="crustStyle" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepRadio" runat="server" GroupName="crustStyle" Text="Deep Dish(+$2)" Checked="True" />
        <br />
        <br />
        <asp:CheckBox ID="pepCheckBox" runat="server" Text="Pepperoni(+$1.50)" />
        <br />
        <asp:CheckBox ID="onionCheckBox" runat="server" Text="Onions(+$0.75)" />
        <br />
        <asp:CheckBox ID="gpCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="rpCheckBox" runat="server" Text="Red Peppers(+$0.75)" />
        <br />
        <asp:CheckBox ID="anchCheckBox" runat="server" Text="Anchovies(+$2.00)" />
        <br />
        <br />
        <h2><span class="auto-style1">Papa Bob&#39;s </span><span style="color:red;" class="auto-style1">Special Deal</span></h2>
        <p>Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers, and Onions to your pizza.</p>
        <p>
            <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
        </p>
        <p>Total:
            <asp:Label ID="totalLabel" runat="server" Text="$0.00"></asp:Label>
        </p>
        <p>&nbsp;</p>
        <p>Sorry, at this time you can only order one pizza Online and pick-up only...we need a better website!</p>
    </form>
</body>
</html>
