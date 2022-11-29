using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Disponibilidad
    {
        private readonly CD_Disponibilidad CD_Disponibilidad = new CD_Disponibilidad();

        #region consultar
        public CE_Disponibilidad Consultar(int Id_disp)
        {
            return CD_Disponibilidad.CD_Consulta(Id_disp);
        }
        #endregion

        #region insertar
        public void Insertar(CE_Disponibilidad disponibilidad)
        {
            CD_Disponibilidad.CD_Insertar(disponibilidad);
        }

        #endregion

        #region Eliminar
        public void Eliminar(CE_Disponibilidad disponibilidad)
        {
            CD_Disponibilidad.CD_Eliminar(disponibilidad);
        }

        #endregion

        #region Actualizar
        public void ActualizarDatos(CE_Disponibilidad disponibilidad)
        {
            CD_Disponibilidad.CD_ActualizarDatos(disponibilidad);
        }
        #endregion

        #region verUsuarios

        public DataTable Cargardisponibilidad()
        {
            return CD_Disponibilidad.CargarDisponibilidad();
        }

        #endregion
                
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
