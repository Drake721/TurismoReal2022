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

        #region insert
        public void CD_Insertar(CE_Disponibilidad disponibilidad)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_DI_insertar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@descr_estado", disponibilidad.DESCR_ESTADO);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region consulta
        public CE_Disponibilidad CD_Consulta(int @id_disp)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_DI_consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("id_disp", SqlDbType.Int).Value = id_disp;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.DESCR_ESTADO = Convert.ToString(row[1]);
            return ce;
        }
        #endregion

        #region Eliminar
        public void CD_Eliminar(CE_Disponibilidad disponibilidad)
        {
            SqlCommand com = new SqlCommand
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_DI_eliminar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_disp", disponibilidad.ID_DISP);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region Actualizar Datos
        public void CD_ActualizarDatos(CE_Disponibilidad disponibilidad)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_DI_actualizar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_disp", disponibilidad.ID_DISP);
            com.Parameters.AddWithValue("@descr_estado", disponibilidad.DESCR_ESTADO);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();

        }
        #endregion

        #region cargar cargos
        public DataTable CargarDisponibilidad()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_DI_cargarDisp", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();
            return dt;
        }
        #endregion

        #region IDDisponibilidad
        public int ID_DISP(string DESCR_ESTADO)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_DI_id_disp",
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
            SqlDataAdapter da = new SqlDataAdapter("SP_DI_cargardescr_estado", con.AbrirConexion());
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
                CommandText = "SP_DI_cargardisponibilidad",
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
