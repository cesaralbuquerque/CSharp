<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastraCliente.aspx.cs" Inherits="Exe_3_MVP.View.CadastraCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="codigo"></asp:Label>
        <asp:TextBox ID="TextBoxCodigo" runat="server"></asp:TextBox>
        <BR>
        <asp:Label ID="Label2" runat="server" Text="nome"></asp:Label>
        <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox>
        <BR><BR>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        
        <BR><BR><BR><BR>

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
