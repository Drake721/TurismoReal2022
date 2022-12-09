using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Inventario
    {

        private readonly CD_Inventario objDatos = new CD_Inventario();

        //crud DPTO
        #region consultar
        public CE_Inventario_DPTO Consultar(int id_inv)
        {
            return objDatos.CD_Consulta(id_inv);
        }
        #endregion

        #region insertar
        public void Insertar(CE_Inventario_DPTO Inventario)
        {
            objDatos.CD_Insertar(Inventario);
        }

        #endregion

        #region Eliminar
        public void Eliminar(CE_Inventario_DPTO Inventario)
        {
            objDatos.CD_Eliminar(Inventario);
        }

        #endregion

        #region Actualizar
        public void ActualizarDatos(CE_Inventario_DPTO Inventario)
        {
            objDatos.CD_ActualizarDatos(Inventario);
        }
        #endregion

        //ver Dpto
        #region verDPTO

        public DataTable Cargarinventario()
        {
            return objDatos.CargarInventario();
        }

        public DataTable CargarDptoinv(int Id_dpto)
        {
            return objDatos.CargarInventariofil(Id_dpto);
        }
        #endregion

        #region id
        public int id_inv(string nombre_inventario)
        {
            return objDatos.id_inv(nombre_inventario);
        }
        #endregion

        #region nombre
        public CE_Inventario_DPTO nombre_inventario(int id_inv)
        {

            return objDatos.nombre_inv(id_inv);
        }

        #endregion

      /*  #region BuscarDPTO

        public DataTable Buscar(string buscar)
        {
            return objDatos.Buscar(buscar);
        }

        #endregion*/


    }
}
