<%@ Page Title="" Language="C#" MasterPageFile="~/Docente.Master" AutoEventWireup="true" CodeBehind="FrmDocente.aspx.cs" Inherits="CapaPresentacion.Formularios.FrmDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="content-header">
        <h3 style="text-align:center"><b>DATOS GENERALES</b></h3>
    </section>
    <section class="content" style="padding-bottom:276px;">
        <div class="row">
            <div class="col-md-6" style="margin-left:430px">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Nombres:</label>
                            <div class="form-group">
                                <asp:TextBox ID="txtNombres" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Apellidos:</label>
                            <div class="form-group">
                                <asp:TextBox ID="txtApellidos" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>N° de Documento:</label>
                            <div class="form-group">
                                <asp:TextBox ID="txtNumDoc" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Fecha de Nacimiento:</label>
                            <div class="form-group">
                                <asp:TextBox ID="txtFechaNaci" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Teléfono:</label>
                            <div class="form-group">
                                <asp:TextBox ID="txtTelefono" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Direccion:</label>
                            <div class="form-group">
                                <asp:TextBox ID="txtDireccion" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
