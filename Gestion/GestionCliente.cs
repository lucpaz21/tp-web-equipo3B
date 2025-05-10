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
                datos.setearConsulta("SELECT Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP from CLIENTES where Documento= @Documento");
                datos.setearParametro("@Documento", cliente.Documento);

                datos.ejecutarLectura();

                if (!datos.Lector.Read())
                {
                    Console.WriteLine("El cliente no se encuentra registrado");
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
