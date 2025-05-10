<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWebASP.NETInicial_equipo_3b.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <link href="<%= ResolveUrl("~/Content/Default.css") %>" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="FondoPantalla">
    <h1>Bienvenido al catalogo de productos</h1>
    <h2>Dentro de este vas a poder conseguir los productos que desees</h2>
    <a class="CanjeVoucher" aria-current="page" href="/IngresarCodigo.aspx">¡Voucher disponible para canjear!</a>
</div>
</asp:Content>
