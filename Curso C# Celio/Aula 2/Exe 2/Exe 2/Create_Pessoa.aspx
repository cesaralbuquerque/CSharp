<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create_Pessoa.aspx.cs" Inherits="Exe_2.Cadastro_Pessoa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
        
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Endereço"></asp:Label>
        
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        
    </div>
        <div>
        <asp:Label ID="Label3" runat="server" Text="Telefone:"></asp:Label>
        
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        
    </div>
        <div>
        <asp:Label ID="Label4" runat="server" Text="Idade:"></asp:Label>
        
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        
    </div>
    <div>
        <asp:Label ID="Label5" runat="server" Text="Salário:"></asp:Label>
        
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        
    </div>
    <div>
        <asp:Label ID="Label6" runat="server" Text="Desconto:"></asp:Label>
        
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Cadastra" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Limpa" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
