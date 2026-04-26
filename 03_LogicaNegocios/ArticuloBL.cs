using Dominio;
using System.Collections.Generic;
using AccesoADatos;
using System;

namespace LogicaNegocio
{
    public class ArticuloBL
    {
        public static List<Articulo> GetByFilter(string codigo, string nombre, string marca, string categoria)
        {
            ArticuloDAO dao = new ArticuloDAO();

            var resultado = dao.GetByFilter(codigo, nombre, marca, categoria);
            
            return resultado;
        }
    }
}