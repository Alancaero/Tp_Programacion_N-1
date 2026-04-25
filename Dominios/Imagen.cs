using System;

namespace Dominio
{
    public class Imagen
    {   
        private string _imagenUrl;

        public int Id { get; set; }
        public Articulo Articulo { get; set; }
        public string ImagenUrl
        {
            get => _imagenUrl;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("URL de imagen obligatoria");
                _imagenUrl = value;
            }
        }
    }
}
