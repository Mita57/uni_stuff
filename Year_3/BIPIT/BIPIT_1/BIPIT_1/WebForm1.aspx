<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BIPIT_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" runat="server" id="threads" placeholder="threads">
            <input type="text" runat="server" id="parts" placeholder="parts" />
            <asp:Button ID="Button1" runat="server" Text="C'mon let's go" OnClick="Button1_Click" />
        </div>
        <div runat="server" id="response"></div>
    </form>
</body>
</html>
