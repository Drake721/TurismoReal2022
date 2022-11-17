using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Cargo
    {
        CD_Cargo CD_Cargo = new CD_Cargo();
        #region idcargo
        public int ID(string NOMBRECARGO)
        {
            return CD_Cargo.ID(NOMBRECARGO);
        }
        #endregion

        #region nombrecargo
        public CE_Cargo NOMBRECARGO(int ID){

            return CD_Cargo.NOMBRECARGO(ID);
        }

        #endregion

        #region listar 
        public List<string> ListarCargos()
        {
            return CD_Cargo.ObtenerCargos();
        }
        #endregion
    }
}
