<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="TPWebASP.NETInicial_equipo_3b.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="Content/Formulario.js" defer></script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--DNI, NOMBRE, APELLIDO, EMAIL, DIRECCIÓN, CIUDAD, COD POSTAL--%>


    <link href="Content/Formulario.css" rel="stylesheet" type="text/css" />
    <div class="form-container">
        <h1>Ingrese sus datos</h1>
        <div class="form-group">
            <label for="dni">DNI</label>
            <asp:TextBox ID="dniText" AutoPostBack="true" runat="server" ClientIDMode="Static" placeholder="Ingrese su DNI" 
                CssClass="form-control" onkeyup="validarNumeros('dniText', 'lbldni', 8);" OnTextChanged="dniText_TextChanged" />
            <asp:Label ID="lbldni" ClientIDMode="Static" runat="server" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label for="nombre">Nombre</label>
            <asp:TextBox ID="nombre" runat="server" ClientIDMode="Static" placeholder="Ingrese su nombre" 
                CssClass="form-control" onkeyup="validarLetras('nombre', 'lblNombre');"/>
            <asp:Label ID="lblNombre" runat="server" ClientIDMode="Static" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label for="apellido">Apellido</label>
            <asp:TextBox ID="apellido" runat="server" ClientIDMode="Static" placeholder="Ingrese su apellido" 
                CssClass="form-control" onkeyup="validarLetras('apellido', 'lblApellido');" />
            <asp:Label ID="lblApellido" runat="server" ClientIDMode="Static" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label for="email">Email</label>
            <asp:TextBox ID="email" runat="server" ClientIDMode="Static" placeholder="Ingrese su email" 
                CssClass="form-control" onkeyup="validarEmail(email, lblEmail);" />
            <asp:Label ID="lblEmail" runat="server" ClientIDMode="Static" ForeColor="Red"></asp:Label>
        </div>

        <div class="form-group">
            <label for="direccion">Dirección</label>
            <asp:TextBox ID="direccion" runat="server" ClientIDMode="Static" placeholder="Ingrese su dirección" 
                CssClass="form-control" onkeyup="validarCamposVacios(direccion, lblDireccion)" />
            <asp:Label ID="lblDireccion" runat="server" ClientIDMode="Static" ForeColor="Red"></asp:Label>
        </div>

        <div class="row">
            <div class="col">
                <div class="form-group">
                    <label for="ciudad">Ciudad</label>
                    <asp:TextBox ID="ciudad" runat="server" ClientIDMode="Static" placeholder="Ingrese su ciudad" 
                        CssClass="form-control" onkeyup="validarLetras('ciudad', 'lblCiudad');"/>
                    <asp:Label ID="lblCiudad" runat="server" ClientIDMode="Static" ForeColor="Red"></asp:Label>
                </div>
            </div>

            <div class="col">
                <div class="form-group">
                    <label for="codigo-postal">Código Postal</label>
                    <asp:TextBox ID="codigoPostal" runat="server" ClientIDMode="Static"  placeholder="Ingrese su código postal" 
                        CssClass="form-control" onkeyup="validarNumeros('codigoPostal', 'lblCp');" />
                    <asp:Label ID="lblCp" runat="server" ClientIDMode="Static" ForeColor="Red"></asp:Label>
                </div>
            </div>
        </div>

        <asp:Button ID="btnEnviar" runat="server" ClientIDMode="Static" Text="Participar"
            OnClick="btnEnviar_Click" CssClass="btn btn-primary" />

        <asp:Label ID="lblMensajeDNIencontrado" runat="server" ForeColor="Red"></asp:Label>
        <asp:Label ID="lblMensajeDNINuevo" OnClientClick="return validarFormulario();" runat="server" ForeColor="Green"></asp:Label>
    </div>

    <%--<script src="Content/Formulario.js"></script>--%>
</asp:Content>

