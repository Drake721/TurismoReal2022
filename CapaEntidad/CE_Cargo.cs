
namespace CapaEntidad
{
    public class CE_Cargo
    {
        private int _ID;
        private int _CODIGO;
        private string _NOMBRECARGO;
        private string _DESCRIPCION;

        public int ID { get => _ID; set => _ID = value; }
        public int CODIGO { get => _CODIGO; set => _CODIGO = value; }
        public string NOMBRECARGO { get => _NOMBRECARGO; set => _NOMBRECARGO = value; }
        public string DESCRIPCION { get => _DESCRIPCION; set => _DESCRIPCION = value; }
    }
}
