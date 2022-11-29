using System;

namespace CapaEntidad
{
    public class CE_MANTENIMIENTO
    {
        private int _id_mant;
        private int _id_dpto;
        private string _nombre_mant;
        private string _descripcion_mant;
        private DateTime _fecha_inicio;
        private DateTime _fecha_termino;
        private int _disponibilidad;
        private int _costo_mantencion;

        public int Id_mant { get => _id_mant; set => _id_mant = value; }
        public int Id_dpto { get => _id_dpto; set => _id_dpto = value; }
        public string Nombre_mant { get => _nombre_mant; set => _nombre_mant = value; }
        public string Descripcion_mant { get => _descripcion_mant; set => _descripcion_mant = value; }
        public DateTime Fecha_inicio { get => _fecha_inicio; set => _fecha_inicio = value; }
        public DateTime Fecha_termino { get => _fecha_termino; set => _fecha_termino = value; }
        public int Disponibilidad { get => _disponibilidad; set => _disponibilidad = value; }
        public int Costo_mantencion { get => _costo_mantencion; set => _costo_mantencion = value; }
    }
}
