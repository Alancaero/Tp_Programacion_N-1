using AccesoADatos;
using Dominio;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class CategoriaBL
    {
        public static List<Categoria> GetCategorias()
        {
            CategoriaDAO dao = new CategoriaDAO();            
            return dao.GetCategorias();
        }
    }
}
