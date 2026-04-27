using AccesoADatos;
using Dominio;
using System;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class ImagenBL
    {
        public static List <Imagen> GetImagenesByIdArticulo(int articuloId)
        {
            ImagenDAO dao = new ImagenDAO();

            List<Imagen> resultado = dao.GetImagenesByIdArticulo(articuloId);

            return resultado;
        }

        public static void Agregar(int idArticulo, string rutaImagen)
        {
            if (idArticulo <= 0)
                throw new Exception("Id de artículo inválido");

            if (string.IsNullOrWhiteSpace(rutaImagen))
                return;

            ImagenDAO dao = new ImagenDAO();

            dao.Agregar(idArticulo, rutaImagen);
        }

    }
}

