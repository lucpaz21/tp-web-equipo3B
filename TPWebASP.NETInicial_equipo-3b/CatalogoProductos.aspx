<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CatalogoProductos.aspx.cs" Inherits="TPWebASP.NETInicial_equipo_3b.CatalogoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="<%= ResolveUrl("~/Content/Catalogo.css") %>" rel="stylesheet" type="text/css" />
    <div class="contenedor">
        <div class="card" style="width: 18rem;">
            <div id="Caurosel1" class="carousel slide">
            <div class="carousel-inner">
                    <div class="carousel-item active">
                        <asp:Image ID="ImagenCarousel1" runat="server" class="card-img-top" alt="..." />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="Imagen2" runat="server" class="card-img-top" alt="..." />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="Imagen3" runat="server" class="card-img-top" alt="..." />
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Anterior</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Siguiente</span>
                </button>
            </div>
            <div class="card-body">
                <h5 class="card-title"><asp:Label ID="lblTitulo1" runat="server" Text="Titulo Tarjeta"></asp:Label></h5>
                <p class="card-text"><asp:Label ID="lblDescripcion1" runat="server" Text="Some quick example text to build on the card title and make up the bulk of the card's content."></asp:Label></p>
                <a href="Formulario.aspx" class="btn btn-primary">Lo quiero</a>
            </div>
        </div>
        <div class="card" style="width: 18rem;">
                  <div id="Caurosel2" class="carousel slide">
            <div class="carousel-inner">
                    <div class="carousel-item active">
                        <asp:Image ID="ImagenCarousel2" runat="server" class="card-img-top" alt="..." />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="Image2" runat="server" class="card-img-top" alt="..." />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="Image3" runat="server" class="card-img-top" alt="..." />
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Anterior</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Siguiente</span>
                </button>
            </div>
            <div class="card-body">
                <h5 class="card-title"><asp:Label ID="lblTitulo2" runat="server" Text="Titulo Tarjeta"></asp:Label></h5>
                <p class="card-text"><asp:Label ID="lblDescripcion2" runat="server" Text="Some quick example text to build on the card title and make up the bulk of the card's content."></asp:Label></p>
                <a href="Formulario.aspx" class="btn btn-primary">Lo quiero</a>
            </div>
        </div>
        <div class="card" style="width: 18rem;">
              <div id="Caurosel3" class="carousel slide">
            <div class="carousel-inner">
                    <div class="carousel-item active">
                        <asp:Image ID="ImagenCarousel3" runat="server" class="card-img-top" alt="..." />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="Image5" runat="server" class="card-img-top" alt="..." />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="Image6" runat="server" class="card-img-top" alt="..." />
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Anterior</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Siguiente</span>
                </button>
            </div>
            <div class="card-body">
                <h5 class="card-title"><asp:Label ID="lblTitulo3" runat="server" Text="Titulo Tarjeta"></asp:Label></h5>
                <p class="card-text"><asp:Label ID="lblDescripcion3" runat="server" Text="Some quick example text to build on the card title and make up the bulk of the card's content."></asp:Label></p>
                <a href="Formulario.aspx" class="btn btn-primary">¡Lo quiero!</a>
            </div>
        </div>
    </div>
    <asp:GridView runat="server" ID="dvgArticulos"></asp:GridView>
</asp:Content>
