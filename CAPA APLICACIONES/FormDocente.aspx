<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormDocente.aspx.cs" Inherits="CAPA_APLICACIONES.Home_Master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            
    <div>
        <label>Nombres:</label>
    </div>
    <div>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Apellido Paterno:</label>
    </div>
    <div>
        <asp:TextBox ID="txtApePa" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Apellido Materno:</label>
    </div>
    <div>
        <asp:TextBox ID="txtApeMa" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Número de Documento:</label>
    </div>
    <div>
        <asp:TextBox ID="txtNumDoc" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Sexo:</label>
    </div>
    <div>
        <asp:DropDownList ID="txtSexo" runat="server">
            <asp:ListItem Selected="true">- Seleccione -</asp:ListItem>
            <asp:ListItem Selected="False" Value="M">Masculino</asp:ListItem>
            <asp:ListItem Selected="False" Value="F">Femenino</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div>
        <label>Fecha de Nacimiento:</label>
    </div>
    <div>
        <asp:TextBox ID="txtNaci" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Dirección:</label>
    </div>
    <div>
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Télefono:</label>
    </div>
    <div>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:TextBox ID="txtNivel" runat="server"></asp:TextBox>
    </div>
    <div>
        <label>Nivel:</label>
    </div>
    <div>
        <asp:Button ID="btnRegistrarAlumno" runat="server" text="Registrar" OnClick="btnRegistrarAlumno_Click" />
    </div>
        </div>
    </form>
</body>
</html>
