using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using Dominio;
using Gestion;

namespace TPWebASP.NETInicial_equipo_3b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                lblMensajeDNIencontrado.Text = "";
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Gestion.AccesoDatos datos = new AccesoDatos();
            GestionVoucher gestionVoucher = new GestionVoucher();
            Articulo articulo = new Articulo();
            Vouchers voucher = new Vouchers();
            

            Clientes cliente = new Clientes();
            cliente.Documento = dniText.Text;
            cliente.NombreCliente = nombre.Text;
            cliente.ApellidoCliente = apellido.Text;
            cliente.CorreoCliente = email.Text;
            cliente.Direccion = direccion.Text;
            cliente.Ciudad = ciudad.Text;
            cliente.Cp = int.Parse(codigoPostal.Text);

            try
            {
                datos.setearConsulta("SELECT Id, Documento FROM Clientes WHERE Documento = @Documento");
                datos.setearParametro("@Documento", cliente.Documento);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                { 
                    string encontrado = datos.Lector["Documento"].ToString();
                    cliente.ClienteId = (int)datos.Lector["Id"];
                    lblMensajeDNINuevo.Text = "";
                    lblMensajeDNIencontrado.Text = "El documento ya está registrado: " + encontrado;
                    dniText.Text = "";
                    nombre.Text = "";
                    apellido.Text = "";
                    email.Text = "";
                    direccion.Text = "";
                    ciudad.Text = "";
                    codigoPostal.Text = "";

                    lblMensajeDNINuevo.Text = "";

                }
                else
                {
                    datos.cerrarConexion();
                    datos.limpiarParametros();

                    datos.setearConsulta("INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " +
                                         "VALUES (@Documento, @NombreCliente, @ApellidoCliente, @CorreoCliente, @Direccion, @Ciudad, @Cp)");

                    datos.setearParametro("@Documento", cliente.Documento);
                    datos.setearParametro("@NombreCliente", cliente.NombreCliente);
                    datos.setearParametro("@ApellidoCliente", cliente.ApellidoCliente);
                    datos.setearParametro("@CorreoCliente", cliente.CorreoCliente);
                    datos.setearParametro("@Direccion", cliente.Direccion);
                    datos.setearParametro("@Ciudad", cliente.Ciudad);
                    datos.setearParametro("@Cp", cliente.Cp);

                    datos.ejecutarAccion();
                    lblMensajeDNIencontrado.Text = "";
                    lblMensajeDNINuevo.Text = "Cliente registrado exitosamente.";
                    dniText.Text = "";
                    nombre.Text = "";
                    apellido.Text = "";
                    email.Text = "";
                    direccion.Text = "";
                    ciudad.Text = "";
                    codigoPostal.Text = "";

                    datos.cerrarConexion();
                    datos.limpiarParametros();

                    datos.setearConsulta("SELECT Id FROM Clientes WHERE Documento = @Documento");
                    datos.setearParametro("@Documento", cliente.Documento);
                    datos.ejecutarLectura();

                    if (datos.Lector.Read())
                    {
                        cliente.ClienteId = (int)datos.Lector["Id"];
                    }

                }

                if (Session["CodVoucher"]!= null && Session["ArticuloElegido"] != null) 
                {
                    voucher.CodVoucher = Session["CodVoucher"].ToString();
                    articulo.IDArticulo = (int)Session["ArticuloElegido"];

                    if (!string.IsNullOrEmpty(voucher.CodVoucher) && articulo.IDArticulo != 0 && cliente.ClienteId != 0)
                    {
                        bool formularioEnviado = gestionVoucher.insertarDatosenVouchers(articulo, voucher, cliente);

                        if (formularioEnviado)
                        {
                            Response.Redirect("Default.aspx", false);
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        protected void dniText_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(dniText.Text)) { return; }

                Gestion.AccesoDatos datos = new Gestion.AccesoDatos();

                datos.setearConsulta("SELECT Nombre, Apellido, Email, Direccion, Ciudad, CP FROM Clientes WHERE Documento = @Documento");
                datos.setearParametro("@Documento", dniText.Text);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    nombre.Text = datos.Lector["Nombre"].ToString();
                    apellido.Text = datos.Lector["Apellido"].ToString();
                    email.Text = datos.Lector["Email"].ToString();
                    direccion.Text = datos.Lector["Direccion"].ToString();
                    ciudad.Text = datos.Lector["Ciudad"].ToString();
                    codigoPostal.Text = datos.Lector["CP"].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }
    }

}








