<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="FrmPregunta.aspx.cs" Inherits="CapaPresentacion.Formularios.FrmExamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>PREGUNTAS</h1>
    <div class="container"> 
        <div class="panel panel-primary">
            <h2 class="panel-title">

            </h2>
        </div>
    </div>
    <div>
        <asp:Label ID="lblPregunta" runat="server" Text="PREGUNTA"></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>
