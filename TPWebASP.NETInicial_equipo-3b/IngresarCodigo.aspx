<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IngresarCodigo.aspx.cs" Inherits="TPWebASP.NETInicial_equipo_3b.IngresarCodigo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-2"></div>
        <div class="col">
              <div class="mb-3">
                <label for="txtCodigo" class="form-label" style="color: blueviolet; font-weight: bold">Ingresa el código de tu voucher: </label>
                <asp:TextBox ID="txtCodigo" CssClass="form-control"  runat="server" />
              </div>
              <asp:Button Text="Siguiente" CssClass="btn btn-primary" ID="btnSiguiente" OnClick="btnSiguiente_Click" runat="server" />
        </div>
        <div class ="col-2"></div>
        
    </div>

</asp:Content>
