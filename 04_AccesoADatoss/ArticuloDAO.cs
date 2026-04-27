
using Dominio;
using System;
using System.Collections.Generic;

namespace AccesoADatos
{
    public class ArticuloDAO
    {
        private AccesoADatosDAO _accesoADatos = new AccesoADatosDAO();

        public List<Articulo> GetByFilter(string codigo, string nombre, string marca, string categoria)
        {

            string consulta =
                " SELECT " +
                    "A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Id AS IdMarca," +
                    " M.Descripcion AS Marca, C.Id AS IdCategoria, C.Descripcion AS Categoria, " +
                    "count (I.Id) as CantidadImagenes " +
                    "FROM ARTICULOS A " +
                    "INNER JOIN MARCAS M ON M.Id = A.IdMarca " +
                    "LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria " +
                    "LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id " +
                    "WHERE 1 = 1 ";
                    

            if (!string.IsNullOrEmpty(codigo))
                consulta += " AND A.Codigo LIKE '%" + codigo + "%'";
            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND A.Nombre LIKE '%" + nombre + "%'";
            if (!string.IsNullOrEmpty(marca))
                consulta += " AND M.Descripcion LIKE '%" + marca + "%'";
            if (!string.IsNullOrEmpty(categoria))
                consulta += " AND C.Descripcion LIKE '%" + categoria + "%'";

            consulta += "GROUP BY A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Id, M.Descripcion, C.Id, C.Descripcion";

            try
            {
                _accesoADatos.setearConsulta(consulta);
                _accesoADatos.ejecutarLectura();

                var lista = new List<Articulo>();

                while (_accesoADatos.Lector.Read())
                {
                    var articulo = new Articulo
                    {
                        Id = (int)_accesoADatos.Lector["Id"],
                        Codigo = (string)_accesoADatos.Lector["Codigo"],
                        Nombre = (string)_accesoADatos.Lector["Nombre"],
                        Descripcion = (string)_accesoADatos.Lector["Descripcion"],
                        Precio = (decimal)_accesoADatos.Lector["Precio"],
                        Marca = new Marca
                        {
                            Id = (int)_accesoADatos.Lector["IdMarca"],
                            Descripcion = (string)_accesoADatos.Lector["Marca"]
                        },
                        CantidadImagenes = (int)_accesoADatos.Lector["CantidadImagenes"]

                    }; // dgv explotaba al intentar mostrar la categoría cuando esta era DBnull (articulo posee categoria que ya no existe)
                    if (_accesoADatos.Lector["IdCategoria"] is DBNull)
                    {
                        articulo.Categoria = null;
                    }
                    else
                    {
                        articulo.Categoria = new Categoria
                        {
                            Id = (int)_accesoADatos.Lector["IdCategoria"],
                            Descripcion = _accesoADatos.Lector["Categoria"].ToString()
                        };
                    }
                    lista.Add(articulo);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _accesoADatos.cerrarConexion(); }
        }

        public int Guardar(string codigo, string nombre, int marcaId, int categoriaId, decimal precio, string descripcion)
        {
            try
            {

                _accesoADatos.setearConsulta(
                    "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) " +
                    "OUTPUT INSERTED.Id " +
                    "VALUES ('" + codigo + "', '" + nombre + "', '" + descripcion + "', " + precio + ", " + marcaId + ", " + categoriaId + ")"
                );
                //_accesoADatos.ejecutarAccion();
                _accesoADatos.ejecutarLectura();
                if (_accesoADatos.Lector.Read())
                    return (int)_accesoADatos.Lector["Id"];

                throw new Exception("No se pudo obtener el Id del artículo creado");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el artículo: " + ex.Message);
            }
            finally
            {
                _accesoADatos.cerrarConexion();
            }
        }

        public void Modificar(int id, string codigo, string nombre, int marcaId, int categoriaId, decimal precio, string descripcion)
        {
            try
            {
                _accesoADatos.setearConsulta(
                    "UPDATE ARTICULOS " +
                    "SET Codigo = '" + codigo + "', Nombre = '" + nombre + "', Descripcion = '" + descripcion + "', Precio = " + precio + ", IdMarca = " + marcaId + ", IdCategoria = " + categoriaId +
                    " WHERE Id = " + id
                );
                _accesoADatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el artículo: " + ex.Message);
            }
            finally
            {
                _accesoADatos.cerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                _accesoADatos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = " + id);
                _accesoADatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el artículo: " + ex.Message);
            }
            finally
            {
                _accesoADatos.cerrarConexion();
            }
        }
    }
}