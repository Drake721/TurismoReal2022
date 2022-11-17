namespace CapaEntidad
{
    public class CE_Comuna
    {
        private int _ID_COMUNA;
        private string _NOMBRE_COMUNA;
        private int _ID_REGION;

        public int ID_COMUNA { get => _ID_COMUNA; set => _ID_COMUNA = value; }
        public string NOMBRE_COMUNA { get => _NOMBRE_COMUNA; set => _NOMBRE_COMUNA = value; }
        public int ID_REGION { get => _ID_REGION; set => _ID_REGION = value; }
    }
}
