<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Exe_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Valor 1:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        Operação:<asp:DropDownList ID="DropDownList1" runat="server"  >
            <asp:ListItem Value="Soma">Soma</asp:ListItem>
            <asp:ListItem>Subtração</asp:ListItem>
            <asp:ListItem>Divisão</asp:ListItem>
            <asp:ListItem>Multiplicação</asp:ListItem>
        </asp:DropDownList>
        Valor 2:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calcular" />
        <asp:Label ID="Label1" runat="server" Text="Resultado:"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="____" Enabled="false"></asp:Label>
        </div>
    </form>
</body>
</html>
