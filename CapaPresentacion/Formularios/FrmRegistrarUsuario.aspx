<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="FrmRegistrarUsuario.aspx.cs" Inherits="login.FrmRegistrarUsuario" ClientIDMode="Static"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h3 style="text-align:center"><b>REGISTRO DE DOCENTE</b></h3>
    </section>
    <section class="content" style="padding-bottom:9px">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Nombres:</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Apellido Paterno:</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtApePa" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Apellido Materno:</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtApeMa" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Número de Documento:</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNumDoc" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Sexo:</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="txtSexo" runat="server" CssClass="form-control">
                                <asp:ListItem Selected="true">- Seleccione -</asp:ListItem>
                                <asp:ListItem Selected="False" Value="M">Masculino</asp:ListItem>
                                <asp:ListItem Selected="False" Value="F">Femenino</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        
                        <div class="form-group">
                            <label>Fecha de Nacimiento:</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNaci" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Dirección:</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>Télefono:</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        
            <div align="center">
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnRegistrarDocente" runat="server" CssClass="btn btn-primary" width="200px" text="Registrar"/>
                        </td>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td>
                            <asp:Button ID="btnCancelarDocente" runat="server" CssClass="btn btn-danger" width="200px" text="Cancelar" />
                        </td>
                    </tr>
                </table>
            </div>
            <br/>

        <!-- Datatable Part -->
        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header">
                        <h3 class="box-title">Lista de Alumnos</h3>
                    </div>
                    <div class="box-body table-responsive">
                        <table id="tbl_Alumnos" class="table table-bordered">
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
                            <tbody id="tbl_body_table">
                                <!-- Data por medio de Ajax -->
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Datatable -->
    </section>

    <div class="modal fade" id="imodal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="myModalLabel">Actualizar registro</h4>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label>NOMBRES</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtModalNombre" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>APELLIDOS PATERNOS</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtModalPat" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>APELLIDOS MATERNOS</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtModalMat" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>DNI</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtModalDNI" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label>FECHA NAC</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtModalFecha" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label>TELEFONO</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtModalTelefono" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label>DIRECCIÓN</label>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtModalDireccion" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                    </div>

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" id="btnactualizar">Actualizar</button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="../js/alumno.js"></script>

    <script src="../js/plugins/datatables/dataTables.bootstrap.js"></script>
    <script src="../js/plugins/datatables/jquery.dataTables.js"></script>
</asp:Content>
