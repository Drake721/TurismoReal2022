using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Region
    {
        CD_Region CD_Region = new CD_Region();
        #region idRegion
        public int ID_REGION(string NOMBRE_REGION)
        {
            return CD_Region.ID_REGION(NOMBRE_REGION);
        }
        #endregion

        #region nombreRegion
        public CE_Region NOMBRE_REGION(int ID_REGION)
        {

            return CD_Region.NOMBRE_REGION(ID_REGION);
        }

        #endregion

        #region listarRegion
        public List<string> ListarRegion()
        {
            return CD_Region.ObtenerCargos();
        }
        #endregion
    }
}
