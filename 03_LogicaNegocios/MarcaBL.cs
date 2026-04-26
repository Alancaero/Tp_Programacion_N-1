using AccesoADatos;
using Dominio;
using System;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class MarcaBL
    {
        public static List<Marca> GetMarcas()
        {
            MarcaDAO dao = new MarcaDAO();            
            return dao.GetMarcas();
        }
        public static void Agregar(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new Exception("La descripción es obligatoria");

            ValidarExistencia(descripcion);

            MarcaDAO dao = new MarcaDAO();
            dao.Agregar(descripcion);
        }

        public static void Modificar(int id, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new Exception("La descripción es obligatoria");

            ValidarExistencia( descripcion);

            MarcaDAO dao = new MarcaDAO();
            dao.Modificar(id, descripcion.Trim());
        }

        public static void Eliminar(int id)
        {
            MarcaDAO dao = new MarcaDAO();
            dao.Eliminar(id);
        }

        private static void ValidarExistencia(string descripcion)
        {
            var auxDescripcion = descripcion.Trim().ToUpper();

            List<Marca> marcas = GetMarcas();
            foreach (Marca marca in marcas)
            {
                if (marca.Descripcion.Trim().ToUpper() == auxDescripcion)
                    throw new Exception("La marca ya existe");
            }
        }

    }
}
