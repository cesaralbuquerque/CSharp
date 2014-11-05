<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExemploADO_NET.aspx.cs" Inherits="AppWebAula5.ExemploADO_NET" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Button ID="btnCriarBanco" runat="server" Text="Criar Banco" OnClick="btnCriarBanco_Click" />
        </p>
        <p>
            <asp:Button ID="btnCriarTabela" runat="server" Text="Criar Tabela" OnClick="btnCriarTabela_Click" />
        </p>
        <p>
            <asp:Button ID="btnInserirDados" runat="server" Text="Inserir Dados" OnClick="btnInserirDados_Click" />
        </p>
        <p>
            <asp:Button ID="btnLerDadosConectado" runat="server" Text="Ler Dados - Conectado ao Banco" OnClick="btnLerDadosConectado_Click" />
        </p>
        <p>
            <asp:Button ID="btnLerDadosDesconectado" runat="server" Text="Ler Dados - Desconectado do Banco" OnClick="btnLerDadosDesconectado_Click" />
        </p>
        <p>
            <asp:Button ID="btnAlterarDadosDesconectado" runat="server" Text="Alterar Dados - Desconectado do Banco" OnClick="btnAlterarDadosDesconectado_Click" />
        </p>
        <p>
            <asp:Button ID="btnPreencheGridView" runat="server" Text="Preenche GridView Com Dados do Banco" OnClick="btnPreencheGridView_Click" />
            <br />
            <br />
            <asp:GridView ID="gvTestes" runat="server"></asp:GridView>
        </p>
    </form>
</body>
</html>

