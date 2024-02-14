<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EsercizioW3D3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
           <asp:TextBox ID="TextNome" runat="server"></asp:TextBox>
           <asp:TextBox ID="TextCognome" runat="server"></asp:TextBox>
          <asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem Text="SalaA" Value="SalaA"></asp:ListItem>
    <asp:ListItem Text="SalaB" Value="SalaB"></asp:ListItem>
    <asp:ListItem Text="SalaC" Value="SalaC"></asp:ListItem>
</asp:RadioButtonList>
           <asp:CheckBox ID="Sconto" runat="server" />
           <asp:Label ID="Label1" runat="server" Text="Sconto"></asp:Label>

       </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Compra Biglietto" />
    </form>
</body>
</html>
