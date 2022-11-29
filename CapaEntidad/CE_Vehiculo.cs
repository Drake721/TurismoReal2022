namespace CapaEntidad
{
    public class CE_Vehiculo
    {
        private int _id_vehiculo;
        private string _patente;
        private int _codigo;
        private string _descripcion;
        private int _id_usuario;

        public int Id_vehiculo { get => _id_vehiculo; set => _id_vehiculo = value; }
        public string Patente { get => _patente; set => _patente = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Id_usuario { get => _id_usuario; set => _id_usuario = value; }
    }
}
