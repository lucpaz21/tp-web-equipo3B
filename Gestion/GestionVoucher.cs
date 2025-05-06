using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    public class GestionVoucher
    {
        private Vouchers Vouchers { get; set; }



        public bool buscarVoucher (Vouchers vouchers)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT CodigoVoucher from VOUCHERS where CodigoVoucher = @CodigoVoucher");
                datos.setearParametro("@CodigoVoucher", vouchers.CodVoucher);
                datos.ejecutarLectura();

                if (!datos.Lector.Read())
                {
                    Console.WriteLine("El codigo no es valido");
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
            return true;
        }
    }
}
