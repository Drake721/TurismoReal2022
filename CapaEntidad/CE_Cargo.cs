
namespace CapaEntidad
{
    public class CE_Cargo
    {
        private int _id;
        private int _codigo;
        private string _nombrecargo;
        private string _descripcion;

        public int Id { get => _id; set => _id = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombrecargo { get => _nombrecargo; set => _nombrecargo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
