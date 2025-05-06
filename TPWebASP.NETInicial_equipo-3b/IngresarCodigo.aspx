<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresarCodigo.aspx.cs" Inherits="TPWebASP.NETInicial_equipo_3b.IngresarCodigo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="<%= ResolveUrl("~/Content/IngresoCodigo.css") %>" rel="stylesheet" type="text/css" />
    <div class="row">
        <div class="col-2">
            <div class="voucher-box">
                <div class="voucher">
                    <div class="voucher-text">Voucher</div>
                </div>
            </div>
        </div>
        <div class="col">
            <div class="mb-3">
                <label for="txtCodigo" class="form-label" style="color: #000000; font-size:25px; font-weight: bold">Ingresa el código: </label>
                <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server" />
            </div>
            <asp:Button Text="Aplicar código" CssClass="btn btn-primary" ID="btnSiguiente" OnClick="btnSiguiente_Click" runat="server" />

            <!--mensaje de validacion -->
            <asp:Label ID="lblMensajeValidacion" runat="server"></asp:Label>
        </div>
        <div class="col-2"></div>

    </div>

</asp:Content>
