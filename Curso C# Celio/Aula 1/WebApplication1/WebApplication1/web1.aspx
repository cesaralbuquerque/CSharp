<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web1.aspx.cs" Inherits="WebApplication1.web1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style>
        .stilo
        {
            text-align:right;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Teste evento</h1> 
        <asp:Label ID="Label1" runat="server" Text="LabelTeste"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div>
    <div>
        <h1>CPF</h1>
        <asp:Label ID="Label3" runat="server" Text="CPF"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="stilo" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true" MaxLength="11"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Button" Enabled="false" />
    </div>

        
    </form>
</body>
</html>
