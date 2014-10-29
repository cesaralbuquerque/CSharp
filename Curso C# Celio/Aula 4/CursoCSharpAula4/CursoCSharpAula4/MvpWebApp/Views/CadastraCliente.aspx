<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastraCliente.aspx.cs" Inherits="MvpWebApp.Views.CadastraCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Codigo: &nbsp;
            <asp:TextBox ID="txtCodigo" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            Nome do Cliente:&nbsp;
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
            <br />
            <br />
            <asp:GridView ID="gvClientes" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanging="gvClientes_SelectedIndexChanging">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowCancelButton="False" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
