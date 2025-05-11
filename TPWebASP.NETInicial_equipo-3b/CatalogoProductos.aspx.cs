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

                if (listaArticulos != null && listaArticulos.Count > 0)
                {
                    repArticulos.DataSource = listaArticulos;
                    repArticulos.DataBind();

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