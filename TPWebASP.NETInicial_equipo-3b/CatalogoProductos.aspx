<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CatalogoProductos.aspx.cs" Inherits="TPWebASP.NETInicial_equipo_3b.CatalogoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="<%= ResolveUrl("~/Content/Catalogo.css") %>" rel="stylesheet" type="text/css" />
    <div class="contenedor">
<asp:Repeater ID="repArticulos" runat="server">
    <ItemTemplate>
        <div class="card" style="width: 18rem;">
            <div id='Carousel<%# Eval("IDArticulo") %>' class="carousel slide">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <asp:Image ID="Imagen1" runat="server" ImageUrl='<%# Eval("Imagen[0].ImagenURL") %>' class="card-img-top" alt="primera imagen" />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="Imagen2" runat="server" ImageUrl='<%# Eval("Imagen[1].ImagenURL") %>' class="card-img-top" alt="segunda imagen" />
                    </div>
                    <div class="carousel-item">
                        <asp:Image ID="Imagen3" runat="server" ImageUrl='<%# Eval("Imagen[2].ImagenURL") %>' class="card-img-top" alt="tercera imagen" />
                    </div>
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target='#Carousel<%# Eval("IdArticulo") %>' data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Anterior</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target='#Carousel<%# Eval("IdArticulo") %>' data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Siguiente</span>
                </button>
            </div>
            <div class="card-body">
                <h5 class="card-title"><%# Eval("Nombre") %></h5>
                <p class="card-text"><%# Eval("Descripcion") %></p>
                <asp:Button ID="btnLoQuiero3" CssClass="btn btn-primary" runat="server" Text="¡Lo quiero!" CommandArgument='<%# Eval("IdArticulo") %>' CommandName="SeleccionarArticulo" OnClick="btnLoQuiero3_Click" />
            </div>
        </div>
        
    </ItemTemplate>
</asp:Repeater>
        </div>
    <asp:GridView runat="server" ID="dvgArticulos"></asp:GridView>
</asp:Content>

