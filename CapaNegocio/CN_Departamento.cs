using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Departamento
    {
        private readonly CD_Departamento objDatos = new CD_Departamento();

        //crud DPTO
        #region consultar
        public CE_Departamento Consultar(int ID_DPTO)
        {
            return objDatos.CD_Consulta(ID_DPTO);
        }
        #endregion

        #region insertar
        public void Insertar(CE_Departamento Departamento)
        {
            objDatos.CD_Insertar(Departamento);
        }

        #endregion

        #region Eliminar
        public void Eliminar(CE_Departamento Departamento)
        {
            objDatos.CD_Eliminar(Departamento);
        }

        #endregion

        #region Actualizar
        public void ActualizarDatos(CE_Departamento Departamento)
        {
            objDatos.CD_ActualizarDatos(Departamento);
        }
        #endregion

        #region actualizar IMG
        public void ActualizarIMG(CE_Departamento Departamento)
        {
            objDatos.CD_ActualizarIMG(Departamento);
        }
        #endregion

        #region actualizar IMG1
        public void ActualizarIMG1(CE_Departamento Departamento)
        {
            objDatos.CD_ActualizarIMG1(Departamento);
        }
        #endregion

        #region actualizar IMG2
        public void ActualizarIMG2(CE_Departamento Departamento)
        {
            objDatos.CD_ActualizarIMG2(Departamento);
        }
        #endregion

        #region actualizar estado
        public void ActualizarEstado(CE_Departamento Dpto)
        {
            objDatos.CD_ActualizarEstado(Dpto);
        }
        #endregion

        //ver Dpto
        #region verDPTO

        public DataTable CargarDepartamento()
        {
            return objDatos.CargarDepartamento();
        }

        #endregion

        #region idDPTO
        public int id_dpto(string nombre_dpto)
        {
            return objDatos.id_dpto(nombre_dpto);
        }
        #endregion

        #region nombreDPTO
        public CE_Departamento nombre_dpto(int id_dpto)
        {

            return objDatos.nombre_dpto(id_dpto);
        }

        #endregion

        #region listar 
        public List<string> ListarDPTO()
        {
            return objDatos.ObtenerDpto();
        }
        #endregion

        #region BuscarDPTO

        public DataTable Buscar(string buscar)
        {
            return objDatos.Buscar(buscar);
        }

        #endregion
    }
}
