<%@ Page Language="C#" AutoEventWireup="true" CodeFile="talkadd.aspx.cs" Inherits="talkadd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="TxtTitle" runat="server"></asp:TextBox>
        <asp:Button ID="BtnSub" runat="server" OnClick="BtnSub_Click" Text="添加" />
        
    </div>
    </form>
</body>
</html>
