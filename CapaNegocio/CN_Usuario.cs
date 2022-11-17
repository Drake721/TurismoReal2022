using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private readonly CD_Usuario objDatos = new CD_Usuario();

        //crud usuarios
        #region consultar
        public CE_Usuario Consultar(int ID_USUARIO)
        {
            return objDatos.CD_Consulta(ID_USUARIO);
        }
        #endregion

        #region insertar
        public void Insertar(CE_Usuario Usuario)
        {
            objDatos.CD_Insertar(Usuario);
        }

        #endregion

        #region Eliminar
        public void Eliminar(CE_Usuario Usuario)
        {
            objDatos.CD_Eliminar(Usuario);
        }

        #endregion

        #region Actualizar
        public void ActualizarDatos(CE_Usuario Usuario)
        {
            objDatos.CD_ActualizarDatos(Usuario);
        }
        #endregion

        #region actualizar Clave
        public void ActualizarClave(CE_Usuario Usuario)
        {
            objDatos.CD_ActualizarClave(Usuario);
        }
        #endregion

        #region actualizar IMG
        public void ActualizarIMG(CE_Usuario Usuario)
        {
            objDatos.CD_ActualizarIMG(Usuario);
        }
        #endregion

        //ver usuarios
        #region verUsuarios

        public DataTable CargarUsuarios()
        {
            return objDatos.CargarUsuarios();
        }

        #endregion
    }
}
