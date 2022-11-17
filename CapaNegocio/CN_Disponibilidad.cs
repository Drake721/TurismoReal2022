using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Disponibilidad
    {
        CD_Disponibilidad CD_Disponibilidad = new CD_Disponibilidad();
        #region ID_DISP
        public int ID_DISP(string DESCR_ESTADO)
        {
            return CD_Disponibilidad.ID_DISP(DESCR_ESTADO);
        }
        #endregion

        #region nombreEstado
        public CE_Disponibilidad DESCR_ESTADO(int ID_DISP)
        {

            return CD_Disponibilidad.DESCR_ESTADO(ID_DISP);
        }

        #endregion

        #region listarDisponibilidad
        public List<string> ListarDisponibilidad()
        {
            return CD_Disponibilidad.ObtenerDispo();
        }
        #endregion
    }
}
