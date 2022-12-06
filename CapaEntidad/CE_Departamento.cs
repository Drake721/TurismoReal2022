namespace CapaEntidad
{
    public class CE_Departamento
    {
        private int _ID_DPTO;
        private string _NOMBRE_DPTO;
        private int _TARIFA_DIARIA;
        private string _DIRECCION;
        private int _NRO_DPTO;
        private int _CAPACIDAD;
        private int _ID_COMUNA;
        private int _DISPONIBILIDAD;
        private string _IMAGEN;
        private byte[] _IMG;
        private byte[] _IMG1;
        private byte[] _IMG2;

        public int ID_DPTO { get => _ID_DPTO; set => _ID_DPTO = value; }
        public string NOMBRE_DPTO { get => _NOMBRE_DPTO; set => _NOMBRE_DPTO = value; }
        public int TARIFA_DIARIA { get => _TARIFA_DIARIA; set => _TARIFA_DIARIA = value; }
        public string DIRECCION { get => _DIRECCION; set => _DIRECCION = value; }
        public int NRO_DPTO { get => _NRO_DPTO; set => _NRO_DPTO = value; }
        public int CAPACIDAD { get => _CAPACIDAD; set => _CAPACIDAD = value; }
        public int ID_COMUNA { get => _ID_COMUNA; set => _ID_COMUNA = value; }
        public int DISPONIBILIDAD { get => _DISPONIBILIDAD; set => _DISPONIBILIDAD = value; }
        public string IMAGEN { get => _IMAGEN; set => _IMAGEN = value; }
        public byte[] IMG { get => _IMG; set => _IMG = value; }
        public byte[] IMG1 { get => _IMG1; set => _IMG1 = value; }
        public byte[] IMG2 { get => _IMG2; set => _IMG2 = value; }
    }
}
