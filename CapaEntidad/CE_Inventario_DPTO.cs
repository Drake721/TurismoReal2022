namespace CapaEntidad
{
    public class CE_Inventario_DPTO
    {
        private int _ID_INV;
        private int _ID_DPTO;
        private string _NOMBRE_OBJETO;
        private int _CANT_OBJETO;
        private int _VALOR_UNITARIO_OBJ;

        public int ID_INV { get => _ID_INV; set => _ID_INV = value; }
        public int ID_DPTO { get => _ID_DPTO; set => _ID_DPTO = value; }
        public string NOMBRE_OBJETO { get => _NOMBRE_OBJETO; set => _NOMBRE_OBJETO = value; }
        public int CANT_OBJETO { get => _CANT_OBJETO; set => _CANT_OBJETO = value; }
        public int VALOR_UNITARIO_OBJ { get => _VALOR_UNITARIO_OBJ; set => _VALOR_UNITARIO_OBJ = value; }
    }
}
