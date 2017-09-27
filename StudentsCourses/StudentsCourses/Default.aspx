<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentsCourses.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="assignment1Button" runat="server" OnClick="assignment1Button_Click" Text="Students Enrolled in each Course" />
        <br />
        <br />
        <asp:Button ID="assignment2Button" runat="server" OnClick="assignment2Button_Click" Text="Students and their Courses" />
        <br />
        <br />
        <asp:Button ID="assignment3Button" runat="server" OnClick="assignment3Button_Click" Text="Student Grades by Course" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
    </div>
    </form>
</body>
</html>
