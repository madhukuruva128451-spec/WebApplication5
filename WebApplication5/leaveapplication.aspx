﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="leaveapplicatin.aspx.cs" Inherits="WebApplication5.leaveapplicatin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
        form {
            text-align: center;
            margin-top: 50px;
            border: 1px solid #ccc;
        }
    </style>
<body>
    <form id="form1" runat="server">
        <div>
            LEAVE APPLICATION
            <br />
            EMPLOYEE name
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
           
           
            <br />
            leave type:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Casual Leave</asp:ListItem>
                <asp:ListItem>Sick Leave</asp:ListItem>
                <asp:ListItem>Paid Leave</asp:ListItem>
            </asp:DropDownList>
            <br />
            REASON FOR LEAVE:
            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" />


        </div>
    </form>
</body>
</html>