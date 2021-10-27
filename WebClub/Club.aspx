<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Club.aspx.cs" Inherits="WebClub.vistaClub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 60%;
            margin-left: 252px;
        }
        .auto-style4 {
            width: 141px;
        }
        .auto-style5 {
            width: 231px;
        }
        #form1 {
            height: 370px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style4"> 
        <asp:Label ID="lblId" runat="server" Text="ID:"></asp:Label>
                </td>
                <td class="auto-style5"> <asp:TextBox ID="txtId" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnGuardar" runat="server" Text="GUARDAR" Width="92px" OnClick="btnGuardar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td class="auto-style5"> <asp:TextBox ID="txtNombre" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnModificar" runat="server" Text="MODIFICAR" OnClick="btnModificar_Click" Width="93px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
        <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td class="auto-style5"> <asp:TextBox ID="txtApellido" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnEliminar" runat="server" Text="ELIMINAR" OnClick="btnEliminar_Click" Width="93px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
        <asp:Label ID="lblFechaNacimiento" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
                </td>
                <td class="auto-style5"> <asp:TextBox ID="txtFechaNacimiento" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
        <asp:Label ID="lblPuesto" runat="server" Text="Puesto:"></asp:Label>
                </td>
                <td class="auto-style5"> 
                    <asp:DropDownList ID="ddlPuesto" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style5"> 
        <asp:Label ID="lblBuscarPorPuesto" runat="server" Text="Buscar jugador por puesto:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlBuscarPorPuesto" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBuscarPorPuesto_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            </table>
        <br />

        <asp:GridView ID="gridJugador" runat="server" Width="556px" Height="166px" style="margin-left: 258px; margin-right: 422px"></asp:GridView>


    </form>
</body>
</html>
