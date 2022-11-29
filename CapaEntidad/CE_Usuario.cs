
namespace CapaEntidad
{
    public class CE_Usuario
    {
        private int _id_usuario;
        private string _email;
        private string _clave;
        private int _celular;
        private string _rut;
        private string _nombres;
        private string _apellidopaterno;
        private string _apellidomaterno;
        private byte[] _img;
        private int _idcargo;
        private string _patron;

        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }
        public string Email { get => _email; set => _email = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public int Celular { get => _celular; set => _celular = value; }
        public string Rut { get => _rut; set => _rut = value; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidopaterno { get => _apellidopaterno; set => _apellidopaterno = value; }
        public string Apellidomaterno { get => _apellidomaterno; set => _apellidomaterno = value; }
        public byte[] Img { get => _img; set => _img = value; }
        public int Idcargo { get => _idcargo; set => _idcargo = value; }
        public string Patron { get => _patron; set => _patron = value; }
    }
}
