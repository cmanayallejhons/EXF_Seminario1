<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginn.aspx.cs" Inherits="CAPA_APLICACIONES.Loginn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
            <asp:Button ID="btnIngresar" runat="server" Text="Button" OnClick="btnIngresar_Click" />
            <asp:Label ID="lblError" runat="server" Text="" ></asp:Label>
        </div>
    </form>
</body>
</html>
