using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Cargo
    {
        private readonly CD_Cargo CD_Cargo = new CD_Cargo();

        #region consultar
        public CE_Cargo Consultar(int id)
        {
            return CD_Cargo.CD_Consulta(id);
        }
        #endregion

        #region insertar
        public void Insertar(CE_Cargo cargo)
        {
            CD_Cargo.CD_Insertar(cargo);
        }

        #endregion

        #region Eliminar
        public void Eliminar(CE_Cargo cargo)
        {
            CD_Cargo.CD_Eliminar(cargo);
        }

        #endregion

        #region Actualizar
        public void ActualizarDatos(CE_Cargo cargo)
        {
            CD_Cargo.CD_ActualizarDatos(cargo);
        }
        #endregion

        #region verUsuarios

        public DataTable CargarCargo()
        {
            return CD_Cargo.CargarCargos();
        }

        #endregion

        #region idcargo
        public int ID(string nombrecargo)
        {
            return CD_Cargo.ID(nombrecargo);
        }
        #endregion

        #region nombrecargo
        public CE_Cargo nombrecargo(int ID){

            return CD_Cargo.nombrecargo(ID);
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
