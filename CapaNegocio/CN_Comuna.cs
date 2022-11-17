using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Comuna
    {
        CD_Comuna CD_Comuna = new CD_Comuna();
        #region idComuna
        public int ID_COMUNA(string NOMBRE_COMUNA)
        {
            return CD_Comuna.ID_COMUNA(NOMBRE_COMUNA);
        }
        #endregion

        #region nombreComuna
        public CE_Comuna NOMBRE_COMUNA(int ID)
        {

            return CD_Comuna.NOMBRE_COMUNA(ID);
        }

        #endregion

        #region listarComuna 
        public List<string> ListarComuna()
        {
            return CD_Comuna.ObtenerCargos();
        }
        #endregion
    }
}
