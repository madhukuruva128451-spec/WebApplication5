<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
﻿<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="WebForm1.aspx.cs"
    Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Academic Calendar</title>
</head>

<body>
    <form id="form2" runat="server">
        <div>

            <h2>Academic Calendar</h2>

            <asp:Calendar ID="Calendar1" runat="server"
                OnSelectionChanged="Calendar1_SelectionChanged">
            </asp:Calendar>

            <br />

            <asp:Label ID="lblSelectedData" runat="server"
                Text="Please select a date."
                ForeColor="Blue">
            </asp:Label>

            <br />
            <br />

            <asp:Button ID="Button1" runat="server"
                Text="Apply Leave"
                OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>