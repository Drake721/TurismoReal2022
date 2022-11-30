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
    public  class CN_Vehiculo
    {
        private readonly CD_Vehiculo CD_Vehiculo = new CD_Vehiculo();

        #region consultar
        public CE_Vehiculo Consultar(int id_vehiculo)
        {
            return CD_Vehiculo.CD_Consulta(id_vehiculo);
        }
        #endregion

        #region insertar
        public void Insertar(CE_Vehiculo vehiculo)
        {
            CD_Vehiculo.CD_Insertar(vehiculo);
        }

        #endregion

        #region Eliminar
        public void Eliminar(CE_Vehiculo vehiculo)
        {
            CD_Vehiculo.CD_Eliminar(vehiculo);
        }

        #endregion

        #region Actualizar
        public void ActualizarDatos(CE_Vehiculo vehiculo)
        {
            CD_Vehiculo.CD_ActualizarDatos(vehiculo);
        }
        #endregion

        #region verUsuarios

        public DataTable CargarVehiculos()
        {
            return CD_Vehiculo.Cargarvehiculos();
        }

        #endregion

        #region idcargo
        public int id_vehiculo(string patente)
        {
            return CD_Vehiculo.id_vehiculo(patente);
        }
        #endregion

        #region nombrecargo
        public CE_Vehiculo patente(int id_vehiculo)
        {

            return CD_Vehiculo.patente(id_vehiculo);
        }

        #endregion

        #region listar 
        public List<string> ListarVehiculo()
        {
            return CD_Vehiculo.Obtenervehiculo();
        }
        #endregion

    }
}
