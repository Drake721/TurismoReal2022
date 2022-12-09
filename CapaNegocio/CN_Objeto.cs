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
    public class CN_Objeto
    {
        private readonly CD_Objeto objDatos = new CD_Objeto();

        //crud usuarios
        #region consultar
        public CE_Objeto Consultar(int id_obj)
        {
            return objDatos.CD_Consulta(id_obj);
        }
        #endregion

        #region insertar
        public void Insertar(CE_Objeto objeto)
        {
            objDatos.CD_Insertar(objeto);
        }

        #endregion

        #region Eliminar
        public void Eliminar(CE_Objeto objeto)
        {
            objDatos.CD_Eliminar(objeto);
        }

        #endregion

        #region Actualizar
        public void ActualizarDatos(CE_Objeto objeto)
        {
            objDatos.CD_ActualizarDatos(objeto);
        }
        #endregion
        
        //ver Objetos
        #region Cargarobjeto

        public DataTable CargarObjetos()
        {
            return objDatos.CargarObjeto();
        }

        #endregion

        #region idObjeto
        public int id_obj(string nombre_objeto)
        {
            return objDatos.id_Objeto(nombre_objeto);
        }
        #endregion

        #region nombreUsuario
        public CE_Objeto nombre_objeto(int id_obj)
        {

            return objDatos.nombres(id_obj);
        }

        #endregion

        #region listarRegion
        public List<string> ListarObjeto()
        {
            return objDatos.ObtenerObjetos();
        }
        #endregion


    }
}
