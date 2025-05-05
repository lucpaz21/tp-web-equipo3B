using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Gestion
{
    public class GestionMarca
    {

        public void ModificarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update MARCAS set Descripcion = @Descripcion where Id = @Id");
                datos.setearParametro("@Descripcion", marca.Nombre);
                datos.setearParametro("@Id", marca.Id);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }



        //Listar marca
        public List<Marca> listarMarca()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];


                    if (!(datos.Lector["Descripcion"] is DBNull))
                      aux.Nombre = (string)datos.Lector["Descripcion"];


                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { 
                datos.cerrarConexion();
            }
        }

        public void Agregar(Marca marca) {

            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("Insert into MARCAS (Descripcion) values ('" + marca.Nombre + "')");
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        
        }

        public void EliminarMarca(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from MARCAS where Id=@Id");
                datos.setearParametro("@Id", Id);
                datos.ejecutarLectura();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
