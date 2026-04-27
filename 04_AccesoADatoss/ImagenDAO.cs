using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class ImagenDAO
    {
        private AccesoADatosDAO _accesoADatos = new AccesoADatosDAO();

        public List<Imagen> GetImagenesByIdArticulo(int idArticulo)
        {
            try
            {
                List<Imagen> lista = new List<Imagen>();
                _accesoADatos.setearConsulta("SELECT Id, IdArticulo, ImagenUrl " + "FROM IMAGENES " + "WHERE IdArticulo = " + idArticulo);        
                _accesoADatos.ejecutarLectura();

                while (_accesoADatos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)_accesoADatos.Lector["Id"];
                    aux.IdArticulo = (int)_accesoADatos.Lector["IdArticulo"];
                    aux.ImagenUrl =(string)_accesoADatos.Lector["ImagenUrl"];
                    lista.Add(aux);
                }
                return lista;
            } catch (Exception) {
                throw;
            } finally { _accesoADatos.cerrarConexion(); }
        }
        public void Agregar(int idArticulo, string imagenUrl)
        {
            try
            {
                _accesoADatos.setearConsulta(
                    "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) " +
                    "VALUES (" + idArticulo + ", '" + imagenUrl + "')"
                );

                _accesoADatos.ejecutarAccion();
            }
            catch (Exception )
            {
                throw ;
            }
            finally
            {
                _accesoADatos.cerrarConexion();
            }
        }
    }
}
