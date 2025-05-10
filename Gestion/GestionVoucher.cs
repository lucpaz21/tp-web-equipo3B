using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public bool voucherUtilizado(Vouchers vouchers)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT IdCliente, FechaCanje, IdArticulo from Vouchers where CodigoVoucher = @CodigoVoucher");
                datos.setearParametro("@CodigoVoucher", vouchers.CodVoucher);
                

                datos.ejecutarLectura();

                if (datos.Lector.Read() && (datos.Lector.IsDBNull(0) || datos.Lector.IsDBNull(1) || datos.Lector.IsDBNull(2)))
                {
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

        public bool insertarIdArticuloenVouchers(Articulo articulo, Vouchers voucher)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE VOUCHERS SET IdArticulo=@IdArticulo WHERE CodigoVoucher=@CodigoVoucher");
                datos.setearParametro("@CodigoVoucher", voucher.CodVoucher);
                datos.setearParametro("@IdArticulo", articulo.IDArticulo);
                datos.ejecutarAccion();

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

           
        }

    }
}
