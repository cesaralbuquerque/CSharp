<%@ Page Title="Fornecedores" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Fornecedores.aspx.cs" Inherits="AppWebAula5.View.Fornecedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <br />
    <div class="row">
        <label>Código:</label>
        <asp:TextBox ID="txtCodigo" runat="server" ReadOnly="true" CssClass="input"></asp:TextBox>
    </div>
    <div class="row">
        <label>CPF:</label>
        <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <label>Nome:</label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <label>SobreNome:</label>
        <asp:TextBox ID="txtSobreNome" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <label>Endereço:</label>
        <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <label>Bairro:</label>
        <asp:TextBox ID="txtBairro" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <label>Cidade:</label>
        <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <label>UF:</label>
        <asp:TextBox ID="txtUF" runat="server" MaxLength="2"></asp:TextBox>
    </div>
    <br />
    <br />
    <div class="row">
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-default" />
    </div>
</asp:Content>
