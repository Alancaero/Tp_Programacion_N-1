using AccesoADatos;
using Dominio;
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

    }
}
