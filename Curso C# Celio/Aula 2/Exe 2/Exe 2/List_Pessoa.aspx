<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List_Pessoa.aspx.cs" Inherits="Exe_2.List_Pessoa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>

        </table>
        <asp:Table ID="Table1" runat="server"></asp:Table>
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cadastrar" />
    </form>
</body>
</html>
