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

        public string codvoucher {  get; set; }
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

                        Session.Add("IdArticulo1", art1.IDArticulo);
                    }

                    if (listaArticulos.Count > 1)
                    {
                        Articulo art2 = listaArticulos[1];
                        ImagenCarousel2.ImageUrl = art2.Imagen[0].ImagenURL;
                        lblTitulo2.Text = art2.Nombre;
                        lblDescripcion2.Text = art2.Descripcion;

                        Session.Add("IdArticulo2", art2.IDArticulo);
                    }

                    if (listaArticulos.Count > 2)
                    {
                        Articulo art3 = listaArticulos[2];
                        ImagenCarousel3.ImageUrl = art3.Imagen[0].ImagenURL;
                        lblTitulo3.Text = art3.Nombre;
                        lblDescripcion3.Text = art3.Descripcion;

                        Session.Add("IdArticulo3", art3.IDArticulo);
                    }
                }
            }

            codvoucher = Session["CodVoucher"] != null ? Session["CodVoucher"].ToString() : "";
        }

        protected void btnLoQuiero1_Click(object sender, EventArgs e)
        {

            if (Session["IdArticulo1"] != null) 
            {
                Session["ArticuloElegido"] = Session["IdArticulo1"];
                Response.Redirect("Formulario.aspx", false);

            }

            
            
        }

        protected void btnLoQuiero2_Click(object sender, EventArgs e)
        {
            if (Session["IdArticulo2"] != null)
            {
                Session["ArticuloElegido"] = Session["IdArticulo2"];
                Response.Redirect("Formulario.aspx", false);

            }

        }

        protected void btnLoQuiero3_Click(object sender, EventArgs e)
        {
            if (Session["IdArticulo3"] != null)
            {
                Session["ArticuloElegido"] = Session["IdArticulo3"];
                Response.Redirect("Formulario.aspx", false);

            }
        }
    }
}