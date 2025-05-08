using System;
using System.Collections.Generic;
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

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Gestion.AccesoDatos datos = new AccesoDatos();

            Clientes cliente = new Clientes();
            cliente.Documento = dni.Text;
            cliente.NombreCliente = nombre.Text;
            cliente.ApellidoCliente = apellido.Text;
            cliente.CorreoCliente = email.Text;
            cliente.Direccion = direccion.Text;
            cliente.Ciudad = ciudad.Text;
            cliente.Cp = int.Parse(codigoPostal.Text);

            try
            {
                datos.setearConsulta("SELECT Documento FROM Clientes WHERE Documento = @Documento");
                datos.setearParametro("@Documento", cliente.Documento);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    string encontrado = datos.Lector["Documento"].ToString();
                    lblMensaje.Text = "El documento ya está registrado: " + encontrado;
                }
                else
                {
                    datos.setearConsulta("INSERT INTO Clientes (Documento, NombreCliente, ApellidoCliente, CorreoCliente, Direccion, Ciudad, Cp) " +
                                         "VALUES (@Documento, @NombreCliente, @ApellidoCliente, @CorreoCliente, @Direccion, @Ciudad, @Cp)");

                    datos.setearParametro("@Documento", cliente.Documento);
                    datos.setearParametro("@NombreCliente", cliente.NombreCliente);
                    datos.setearParametro("@ApellidoCliente", cliente.ApellidoCliente);
                    datos.setearParametro("@CorreoCliente", cliente.CorreoCliente);
                    datos.setearParametro("@Direccion", cliente.Direccion);
                    datos.setearParametro("@Ciudad", cliente.Ciudad);
                    datos.setearParametro("@Cp", cliente.Cp);

                    datos.ejecutarAccion();
                    Response.Write("Cliente registrado exitosamente.");
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

    }
}








