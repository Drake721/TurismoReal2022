using System;

namespace CapaEntidad
{
    public class CE_MANTENIMIENTO
    {
        private int _ID_MANT;
        private int _ID_DPTO;
        private string _NOMBRE_MANT;
        private string _DESC_MANT;
        private DateTime _FECHA_INICIO;
        private DateTime _FECHA_TERMINO;
        private string _ESTADO;
        private int _COSTO_MANTENCION;

        public int ID_MANT { get => _ID_MANT; set => _ID_MANT = value; }
        public int ID_DPTO { get => _ID_DPTO; set => _ID_DPTO = value; }
        public string NOMBRE_MANT { get => _NOMBRE_MANT; set => _NOMBRE_MANT = value; }
        public string DESC_MANT { get => _DESC_MANT; set => _DESC_MANT = value; }
        public DateTime FECHA_INICIO { get => _FECHA_INICIO; set => _FECHA_INICIO = value; }
        public DateTime FECHA_TERMINO { get => _FECHA_TERMINO; set => _FECHA_TERMINO = value; }
        public string ESTADO { get => _ESTADO; set => _ESTADO = value; }
        public int COSTO_MANTENCION { get => _COSTO_MANTENCION; set => _COSTO_MANTENCION = value; }
    }
}
