<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaPresentacion.Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Acceso al Sistema</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="Bootstrap/Style.css" rel="stylesheet" />
</head>
<body class="bg-black">
    <div class="container h-100">
        <div class="d-flex justify-content-center h-100">
            <div class="user_card">
                <div class="d-flex justify-content-center">
                    <div class="brand_logo_container">
                        <h2 style="background: #e4e7e7; border-radius: 7%; margin-top: 20%; color: #224477">Inicio de Sesión</h2>
                    </div>
                </div>
                <div class="d-flex justify-content-center form_container">
                    <form runat="server">
                        <div class="input-group mb-3">
                            <div class="input-group-append">
                                <span class="input-group-text"><i class="fas fa-user"></i></span>
                            </div>
                            <asp:TextBox ID="txtUsuario" class="form-control input_user" placeholder="Username" runat="server"></asp:TextBox>
                        </div>
                        <div class="input-group mb-3">
                            <div class="input-group-append">
                                <span class="input-group-text"><i class="fas fa-key"></i></span>
                            </div>
                            <asp:TextBox ID="txtContrasenia" type="password" class="form-control input_pass" value="" placeholder="Password" runat="server"></asp:TextBox>
                        </div>
                        <div class="input-group mb-3">
                            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
                        </div>
                        <div class="d-flex justify-content-center mt-3 login_container">
                            <asp:Button ID="btnIngresar" class="btn login_btn" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    <footer id="sticky-footer" class="py-4 text-white-50">
        <div class="container text-center">
            <small>Av.André Avelino Cáseres</small>
        </div>
    </footer>

</body>
</html>
