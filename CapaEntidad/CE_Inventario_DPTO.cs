namespace CapaEntidad
{
    public class CE_Inventario_DPTO
    {
        private int _id_inv;
        private int _id_dpto;     
        private int _id_objeto;
        private string _nombre_inventario;

        public int Id_inv { get => _id_inv; set => _id_inv = value; }
        public int Id_dpto { get => _id_dpto; set => _id_dpto = value; }
        public int Id_objeto { get => _id_objeto; set => _id_objeto = value; }
        public string Nombre_inventario { get => _nombre_inventario; set => _nombre_inventario = value; }
    }
}
