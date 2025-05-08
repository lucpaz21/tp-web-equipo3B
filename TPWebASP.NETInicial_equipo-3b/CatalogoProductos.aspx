<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CatalogoProductos.aspx.cs" Inherits="TPWebASP.NETInicial_equipo_3b.CatalogoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="<%= ResolveUrl("~/Content/Catalogo.css") %>" rel="stylesheet" type="text/css" />
    <div class="contenedor">
        <div class="card" style="width: 18rem;">
            <asp:Image ID="ImagenTarjeta1" runat="server" src="..." class="card-img-top" alt="..."/>
            <div class="card-body">
                <h5 class="card-title"><asp:Label ID="lblTitulo1" runat="server" Text="Titulo Tarjeta"></asp:Label></h5>
                <p class="card-text"><asp:Label ID="lblDescripcion1" runat="server" Text="Some quick example text to build on the card title and make up the bulk of the card's content."></asp:Label></p>
                <a href="Formulario.aspx" class="btn btn-primary">Lo quiero</a>
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <asp:Image ID="ImagenTarjeta2" runat="server" src="..." class="card-img-top" alt="..."/>
            <div class="card-body">
                <h5 class="card-title"><asp:Label ID="lblTitulo2" runat="server" Text="Titulo Tarjeta"></asp:Label></h5>
                <p class="card-text"><asp:Label ID="lblDescripcion2" runat="server" Text="Some quick example text to build on the card title and make up the bulk of the card's content."></asp:Label></p>
                <a href="Formulario.aspx" class="btn btn-primary">Lo quiero</a>
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <asp:Image ID="ImagenTarjeta3" runat="server" src="..." class="card-img-top" alt="..."/>
            <div class="card-body">
                <h5 class="card-title"><asp:Label ID="lblTitulo3" runat="server" Text="Titulo Tarjeta"></asp:Label></h5>
                <p class="card-text"><asp:Label ID="lblDescripcion3" runat="server" Text="Some quick example text to build on the card title and make up the bulk of the card's content."></asp:Label></p>
                <a href="Formulario.aspx" class="btn btn-primary">¡Lo quiero!</a>
            </div>
        </div>
    </div>
    <asp:GridView runat="server" ID="dvgArticulos"></asp:GridView>
</asp:Content>
