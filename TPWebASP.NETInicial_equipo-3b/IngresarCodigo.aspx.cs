using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Gestion;

namespace TPWebASP.NETInicial_equipo_3b
{
    public partial class IngresarCodigo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Gestion.GestionVoucher gestionVoucher = new GestionVoucher();
            
   
            
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                lblMensajeValidacion.Text = "Debes ingresar un código para continuar ";
                return;
            }
            else {
         
                Vouchers voucher = new Vouchers();
                voucher.CodVoucher = txtCodigo.Text;

                if (!gestionVoucher.buscarVoucher(voucher))
                {
                    lblMensajeValidacion.Text = "El codigo de voucher no es válido";
                    return;
                }
                else
                {
                    if(gestionVoucher.voucherUtilizado(voucher))
                    {
                        lblMensajeValidacion.Text = "El codigo de voucher ya fue utilizado";
                        return;
                    }
                    else
                    {
                        Session.Add("CodVoucher", voucher.CodVoucher);
                        Response.Redirect("CatalogoProductos.aspx", false);
                    }
                }
                    
            }
        }
    }
}