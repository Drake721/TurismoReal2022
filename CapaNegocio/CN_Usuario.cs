using System.Collections.Generic;
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
        public CE_Usuario Consultar(int Id_usuario)
        {
            return objDatos.CD_Consulta(Id_usuario);
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
        #region CargarUsuario

        public DataTable CargarUsuarios()
        {
            return objDatos.CargarUsuarios();
        }

        #endregion

        #region login
        public CE_Usuario Login(string email, string clave)
        {
            return objDatos.Logins(email, clave);
        }
        #endregion

        #region idUsuario
        public int id_usuario(string nombres)
        {
            return objDatos.id_usuario(nombres);
        }
        #endregion

        #region nombreUsuario
        public CE_Usuario nombres(int id_usuario)
        {

            return objDatos.nombres(id_usuario);
        }

        #endregion

        #region listar 
        public List<string> ListarUsuario()
        {
            return objDatos.ObtenerUsuarios();
        }
        #endregion

        #region BuscarUsuario

        public DataTable Buscar(string buscar)
        {
            return objDatos.Buscar(buscar);
        }

        #endregion

    }
}
