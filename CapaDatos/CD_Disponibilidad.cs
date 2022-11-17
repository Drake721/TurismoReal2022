using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Disponibilidad
    {
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_Disponibilidad ce = new CE_Disponibilidad();

        #region IDDisponibilidad
        public int ID_DISP(string DESCR_ESTADO)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_DI_ID_DISP",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@DESCR_ESTADO", DESCR_ESTADO);
            object valor = com.ExecuteScalar();
            int ID_DISP = (int)valor;
            con.CerrarConexion();

            return ID_DISP;
        }
        #endregion

        #region Nombreestado
        public CE_Disponibilidad DESCR_ESTADO(int ID_DISP)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_DI_CargarDESCR_ESTADO", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@ID_DISP", SqlDbType.Int).Value = ID_DISP;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.DESCR_ESTADO = Convert.ToString(row[0]);


            return ce;
        }
        #endregion

        #region listarEstados
        public List<string> ObtenerDispo()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_DI_CargarDisponibilidad",
                CommandType = CommandType.StoredProcedure,
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while (reader.Read())
            {
                lista.Add(Convert.ToString(reader["DESCR_ESTADO"]));
            }
            con.CerrarConexion();

            return lista;

        }
        #endregion
    }
}
