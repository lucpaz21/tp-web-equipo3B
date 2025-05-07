<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="TPWebASP.NETInicial_equipo_3b.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="~/Content/Formulario.css" rel="stylesheet" type="text/css" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/Formulario.css" rel="stylesheet" type="text/css" />
    <div class="form-container">
        <h1>Ingrese sus datos</h1>
        <div class="form-group">
            <label for="dni">DNI</label>
            <input type="text" id="dni" placeholder="Ingrese su DNI">
        </div>

        <div class="form-group">
            <label for="nombre">Nombre</label>
            <input type="text" id="nombre" placeholder="Ingrese su nombre">
        </div>

        <div class="form-group">
            <label for="apellido">Apellido</label>
            <input type="text" id="apellido" placeholder="Ingrese su apellido">
        </div>

        <div class="form-group">
            <label for="email">Email</label>
            <input type="email" id="email" placeholder="Ingrese su email">
        </div>

        <div class="form-group">
            <label for="direccion">Dirección</label>
            <input type="text" id="direccion" placeholder="Ingrese su dirección">
        </div>

        <div class="row">
            <div class="col">
                <div class="form-group">
                    <label for="ciudad">Ciudad</label>
                    <input type="text" id="ciudad" placeholder="Ingrese su ciudad">
                </div>
            </div>

            <div class="col">
                <div class="form-group">
                    <label for="codigo-postal">Código Postal</label>
                    <input type="text" id="codigo-postal" placeholder="Ingrese su código postal">
                </div>
            </div>
        </div>

        <button type="submit">Enviar</button>
    </div>
</asp:Content>
