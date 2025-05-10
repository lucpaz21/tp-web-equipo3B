using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Gestion
{
    public class GestionCliente

    {
        private Clientes clientes {  get; set; }

        public bool buscarCliente (Clientes cliente)
        {
            AccesoDatos datos = new AccesoDatos ();

            try
            {
                datos.setearConsulta("SELECT Id, Documento from CLIENTES where Documento= @Documento");
                datos.setearParametro("@Documento", cliente.Documento);

                datos.ejecutarLectura();

                if (!datos.Lector.Read())
                { 
                    return false;
                }
                else
                {
                    cliente.ClienteId = (int)datos.Lector["Id"];
                    return true;
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

        }
    }
}
