using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Articulo
    {
        private string _nombre;

        private string _codigo;

        private decimal _precio;

        public int Id { get; set; }
        
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Nombre obligatorio");
                _nombre = value;
            }
        }

        public string Codigo
        {
            get => _codigo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Código obligatorio");
                _codigo = value;
            }
        }

        public decimal Precio
        {
            get => _precio;
            set
            {
                if (value < 0)
                    throw new Exception("El precio no puede ser negativo");
                _precio = value;
            }
        }


        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }        
        public List<Imagen> Imagenes { get; set; } = new List<Imagen>();


    }
}
