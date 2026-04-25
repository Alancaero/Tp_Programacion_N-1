namespace Dominio
{
    public class Marca
    {       
        private string _descripcion;
        public int Id { get; set; }        
        public string Descripcion
        {
            get => _descripcion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Descripción obligatoria");
                _descripcion = value;
            }
        }
    }
}
