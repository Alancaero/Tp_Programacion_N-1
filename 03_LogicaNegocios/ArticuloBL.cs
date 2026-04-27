using Dominio;
using System.Collections.Generic;
using AccesoADatos;
using System;
using System.Data.SqlTypes;

namespace LogicaNegocio
{
    public class ArticuloBL
    {
        public static List<Articulo> GetByFilter(string codigo, string nombre, string marca, string categoria)
        {
            ArticuloDAO dao = new ArticuloDAO();

            var resultado = dao.GetByFilter(codigo, nombre, marca, categoria);

            if (resultado.Count == 0)            
                throw new Exception("No se encontraron artículos con los filtros ingresados.");
            

            return resultado;
        }

        public static void Guardar(string codigo, string nombre, string marca, string categoria, string precio, string descripcion, string rutaImagen)
        {
            ArticuloDAO dao = new ArticuloDAO();

            if (string.IsNullOrWhiteSpace(marca))
                throw new Exception("Debe seleccionar una marca");

            if (string.IsNullOrWhiteSpace(categoria))
                throw new Exception("Debe seleccionar una categoría");

            if (!decimal.TryParse(precio, out decimal precioDecimal))
                throw new Exception("El precio debe ser un número válido");

            if (precioDecimal < 0)
                throw new Exception("El precio no puede ser negativo");

            var listaMarcas = MarcaBL.GetMarcas();
            var listaCategorias = CategoriaBL.GetCategorias();
            int auxCategoriaId = -1;
            int auxMarcaId = -1;

            foreach (Marca item in listaMarcas)
            {
                if (marca == item.Descripcion)
                {
                    auxMarcaId = item.Id;
                }
            }

            foreach (Categoria item in listaCategorias)
            {
                if (categoria == item.Descripcion)
                {
                    auxCategoriaId = item.Id;
                }
            }
            
            if (auxMarcaId == -1)
                throw new Exception("La marca seleccionada no es válida");

            if (auxCategoriaId == -1)
                throw new Exception("La categoría seleccionada no es válida");

            int idArticulo = dao.Guardar(codigo, nombre, auxMarcaId, auxCategoriaId, precioDecimal, descripcion);

            if (!string.IsNullOrWhiteSpace(rutaImagen))
            {
                ImagenBL.Agregar(idArticulo, rutaImagen);
            }
        }

        public static void Modificar(int id, string codigo, string nombre, string marca, string categoria, string precio, string descripcion, string rutaImagen)
        {
            ArticuloDAO dao = new ArticuloDAO();
            if (string.IsNullOrWhiteSpace(marca))
                throw new Exception("Debe seleccionar una marca");
            if (string.IsNullOrWhiteSpace(categoria))
                throw new Exception("Debe seleccionar una categoría");

            if (!decimal.TryParse(precio, out decimal precioDecimal))
                throw new Exception("El precio debe ser un número válido");

            if (precioDecimal < 0)
                throw new Exception("El precio no puede ser negativo");
            var listaMarcas = MarcaBL.GetMarcas();
            var listaCategorias = CategoriaBL.GetCategorias();
            int auxCategoriaId = -1;
            int auxMarcaId = -1;
            foreach (Marca item in listaMarcas)
            {
                if (marca == item.Descripcion)
                {
                    auxMarcaId = item.Id;
                }
            }
            foreach (Categoria item in listaCategorias)
            {
                if (categoria == item.Descripcion)
                {
                    auxCategoriaId = item.Id;
                }
            }            

            // deberia corregir esto? en lugar de preguntar aca ¿crear un metodo en MarcaBL y CategoriaBL el cual me valide la existencia?
            if (auxMarcaId == -1)
                throw new Exception("La marca seleccionada no es válida");
            if (auxCategoriaId == -1)
                throw new Exception("La categoría seleccionada no es válida");
           
            dao.Modificar(id, codigo, nombre, auxMarcaId, auxCategoriaId, precioDecimal, descripcion);

            if (!string.IsNullOrWhiteSpace(rutaImagen))
            {
                ImagenBL.Agregar(id, rutaImagen);
            }
        }

        public static void Eliminar(int id)
        {
            ArticuloDAO dao = new ArticuloDAO();
            dao.Eliminar(id);
        }
    }
}