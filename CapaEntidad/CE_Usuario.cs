
namespace CapaEntidad
{
    public class CE_Usuario
    {
        private int _ID_USUARIO;
        private string _EMAIL;
        private string _CLAVE;
        private int _CELULAR;
        private string _RUT;
        private string _NOMBRES;
        private string _APELLIDOPATERNO;
        private string _APELLIDOMATERNO;
        private byte[] _IMG;
        private int _IDCARGO;
        private string _PATRON;

        public int ID_USUARIO { get => _ID_USUARIO; set => _ID_USUARIO = value; }
        public string EMAIL { get => _EMAIL; set => _EMAIL = value; }
        public string CLAVE { get => _CLAVE; set => _CLAVE = value; }
        public int CELULAR { get => _CELULAR; set => _CELULAR = value; }
        public string RUT { get => _RUT; set => _RUT = value; }
        public string NOMBRES { get => _NOMBRES; set => _NOMBRES = value; }
        public string APELLIDOPATERNO { get => _APELLIDOPATERNO; set => _APELLIDOPATERNO = value; }
        public string APELLIDOMATERNO { get => _APELLIDOMATERNO; set => _APELLIDOMATERNO = value; }
        public byte[] IMG { get => _IMG; set => _IMG = value; }
        public int IDCARGO { get => _IDCARGO; set => _IDCARGO = value; }
        public string PATRON { get => _PATRON; set => _PATRON = value; }
    }
}
