using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace AccesoADatos
{
    public class AccesoADatosDAO
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;
        private SqlDataReader _lector;

        public SqlDataReader Lector { get => _lector; }
        public AccesoADatosDAO()
        {
            _conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            _comando = new SqlCommand();
            _comando.Connection = _conexion;
        }


        public void setearConsulta(string consulta)
        {
            _comando.CommandType = System.Data.CommandType.Text;
            _comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            _comando.Connection = _conexion;
            try
            {
                _conexion.Open();
                _lector = _comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void cerrarConexion()
        {
            if (_lector != null)
                _lector.Close();
            _conexion.Close();
        }
    }
}
