using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class CategoriaDAO
    {
        private AccesoADatosDAO _accesoADatos = new AccesoADatosDAO();

        public List<Categoria> GetCategorias()
        {
            try
            {
                List<Categoria> lista = new List<Categoria>();
                _accesoADatos.setearConsulta("Select * From Categorias");
                _accesoADatos.ejecutarLectura();

                while (_accesoADatos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)_accesoADatos.Lector["Id"];
                    aux.Descripcion =(string)_accesoADatos.Lector["Descripcion"];
                    lista.Add(aux);
            }
                return lista;
            } catch (Exception) {
                throw;
            } finally { _accesoADatos.cerrarConexion(); }
        }
    }
}
