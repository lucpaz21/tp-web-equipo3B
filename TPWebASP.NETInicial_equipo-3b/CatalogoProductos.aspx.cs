using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Gestion;
using Dominio;
using System.Diagnostics;

namespace TPWebASP.NETInicial_equipo_3b
{
    public partial class CatalogoProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                GestionArticulos gestion = new GestionArticulos();

                List<Articulo> listaArticulos = gestion.listar();

                if (listaArticulos.Count > 0)
                {

                    if (listaArticulos.Count > 0)
                    {
                        Articulo art1 = listaArticulos[0];
                        ImagenCarousel1.ImageUrl = art1.Imagen[0].ImagenURL;
                        lblTitulo1.Text = art1.Nombre;
                        lblDescripcion1.Text = art1.Descripcion;
                    }

                    if (listaArticulos.Count > 1)
                    {
                        Articulo art2 = listaArticulos[1];
                        ImagenCarousel2.ImageUrl = art2.Imagen[0].ImagenURL;
                        lblTitulo2.Text = art2.Nombre;
                        lblDescripcion2.Text = art2.Descripcion;
                    }

                    if (listaArticulos.Count > 2)
                    {
                        Articulo art3 = listaArticulos[2];
                        ImagenCarousel3.ImageUrl = art3.Imagen[0].ImagenURL;
                        lblTitulo3.Text = art3.Nombre;
                        lblDescripcion3.Text = art3.Descripcion;
                    }
                }
            }
        }

        protected void btnLoQuiero1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formulario.aspx", false);
        }

        protected void btnLoQuiero2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formulario.aspx", false);
        }

        protected void btnLoQuiero3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Formulario.aspx", false);
        }
    }
}