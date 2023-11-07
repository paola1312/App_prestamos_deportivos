<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_consulta.aspx.cs" Inherits="App_ConsultaPrestamosDeportivos.frm_consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consultas de prestamos</title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div>
            <asp:TextBox ID="txt_id" runat="server"placeholder="Ingrese su documento de identidad"></asp:TextBox>
            <asp:Button ID="btn_consultar" runat="server" Text="Consultar" OnClick="btn_consultar_Click" />
            <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" />
        </div>
            <br />
            <div>
                <asp:GridView ID="dtg_prestamos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </div>
        </center>
    </form>
</body>
</html>
