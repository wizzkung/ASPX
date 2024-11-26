<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page3.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:TextBox ID="TextBox1" runat="server" Height="32px" Width="79px"></asp:TextBox><br />
            <asp:Button ID="Button13" runat="server" Text="C" OnClick="Clear_Click"/>
        <asp:Button ID="divide" runat="server" Text="/" OnClick="Operation_Click"/>
        <br />
            <asp:Button ID="one" runat="server" Text="1" OnClick="Num_Click"/>
            <asp:Button ID="two" runat="server" Text="2" OnClick="Num_Click"/>
            <asp:Button ID="three" runat="server" Text="3" OnClick="Num_Click"/>
        <asp:Button ID="plus" runat="server" Text="+" OnClick="Operation_Click" />
    
        <br />
   
        <asp:Button ID="four" runat="server" Text="4" OnClick="Num_Click"/>
        <asp:Button ID="five" runat="server" Text="5" OnClick="Num_Click"/>
        <asp:Button ID="six" runat="server" Text="6" OnClick="Num_Click"/>
        <asp:Button ID="minus" runat="server" Text="-" OnClick="Operation_Click"/>
        <br />
            <asp:Button ID="seven" runat="server" Text="7" OnClick="Num_Click"/>
            <asp:Button ID="eight" runat="server" Text="8" OnClick="Num_Click"/>
            <asp:Button ID="nine" runat="server" Text="9" OnClick="Num_Click"/>
          <asp:Button ID="multiply" runat="server" Text="*" OnClick="Operation_Click"/><br />
        
        <asp:Button ID="zero" runat="server" Text="0" OnClick="Num_Click"/>
        
        <asp:Button ID="enter" runat="server" Text="Enter" OnClick="Enter_Click"/>
        
    </form>
</body>
</html>
