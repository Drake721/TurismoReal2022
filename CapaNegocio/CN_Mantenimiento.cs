using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CN_Mantenimiento
    {
        private readonly CD_Mantencion objDatos = new CD_Mantencion();

        #region consultar
        public CE_MANTENIMIENTO Consultar(int Id_mant)
        {
            return objDatos.CD_Consulta(Id_mant);
        }
        #endregion

        #region insertar
        public void Insertar(CE_MANTENIMIENTO mantenimiento)
        {
            objDatos.CD_Insertar(mantenimiento);
        }

        #endregion

        #region Actualizar
        public void ActualizarDatos(CE_MANTENIMIENTO Mantenimiento)
        {
            objDatos.CD_ActualizarDatos(Mantenimiento);
        }
        #endregion

        //ver mant
        #region vermant

        public DataTable CargarMantencion()
        {
            return objDatos.CargarMantencion();
        }

        #endregion

    }
}
