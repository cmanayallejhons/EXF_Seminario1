<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormPersona.aspx.cs" Inherits="CAPA_APLICACIONES.HOME_MASTER" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="NOMBRE"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblApellidoPat" runat="server" Text="APELLIDO PATERNO"></asp:Label>
            <asp:TextBox ID="txtApellidoPat" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblApellidoMat" runat="server" Text="APELLIDO MATERNO"></asp:Label>
            <asp:TextBox ID="txtApellidoMat" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lbldni" runat="server" Text="DNI"></asp:Label>
            <asp:TextBox ID="txtdni" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblFecha" runat="server" Text="FECHA NACIMIENTO"></asp:Label>
            <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblTelefono" runat="server" Text="TELEFONO"></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDireccion" runat="server" Text="DIRECCION"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:DropDownList ID="txtSexo" runat="server" CssClass="form-control">
                                <asp:ListItem Selected="true">- Seleccione -</asp:ListItem>
                                <asp:ListItem Selected="False" Value="M">Masculino</asp:ListItem>
                                <asp:ListItem Selected="False" Value="F">Femenino</asp:ListItem>
                            </asp:DropDownList>
        </div>
        <div>
            <asp:DropDownList ID="txtEstado" runat="server" CssClass="form-control">
                                <asp:ListItem Selected="true">- Seleccione -</asp:ListItem>
                                <asp:ListItem Selected="False" Value="A">ACTIVO</asp:ListItem>
                                <asp:ListItem Selected="False" Value="I">INACTIVO</asp:ListItem>
                            </asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />

        </div>
        <div>
            <table id="tbl_Alumnos">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Nombres</th>
                        <th>A. Paterno</th>
                        <th>A. Materno</th>
                        <th>Identificación</th>
                        <th>Fecha de Nacimiento</th>
                        <th>Teléfono</th>
                        <th>Dirección</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody >
                    <!-- Data por medio de Ajax -->
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
