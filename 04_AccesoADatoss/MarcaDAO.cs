using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class MarcaDAO
    {
        private AccesoADatosDAO _accesoADatos = new AccesoADatosDAO();

        public List<Marca> GetMarcas()
        {
            try
            {
                List<Marca> lista = new List<Marca>();
                _accesoADatos.setearConsulta("Select * From Marcas");
                _accesoADatos.ejecutarLectura();

                while (_accesoADatos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)_accesoADatos.Lector["Id"];
                    aux.Descripcion =(string)_accesoADatos.Lector["Descripcion"];
                    lista.Add(aux);
            }
                return lista;
            } catch (Exception) {
                throw;
            } finally { _accesoADatos.cerrarConexion(); }
        }

        public void Agregar(string descripcion)
        {
            AccesoADatosDAO datos = new AccesoADatosDAO();

            try
            {
                datos.setearConsulta(
                    "INSERT INTO MARCAS (Descripcion) VALUES ('" + descripcion + "')"
                );

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar la marca: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Modificar(int id, string descripcion)
        {
            AccesoADatosDAO datos = new AccesoADatosDAO();

            try
            {
                datos.setearConsulta(
                    "UPDATE MARCAS SET Descripcion = '" + descripcion + "' WHERE Id = " + id
                );

                datos.ejecutarAccion();
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            AccesoADatosDAO datos = new AccesoADatosDAO();

            try
            {
                datos.setearConsulta(
                    "DELETE FROM MARCAS WHERE Id = " + id
                );

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la marca: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}
