using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Region
    {
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_Region ce = new CE_Region();

        #region IDCOMUNA
        public int ID_REGION(string NOMBRE_REGION)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_R_IDREGION",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@NOMBRE_REGION", NOMBRE_REGION);
            object valor = com.ExecuteScalar();
            int ID_REGION = (int)valor;
            con.CerrarConexion();

            return ID_REGION;
        }
        #endregion

        #region NombreComuna
        public CE_Region NOMBRE_REGION(int ID_REGION)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_R_CargarNombreRegion", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@ID_REGION", SqlDbType.Int).Value = ID_REGION;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.NOMBRE_REGION = Convert.ToString(row[0]);


            return ce;
        }
        #endregion

        #region listarComuna
        public List<string> ObtenerCargos()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_R_CargarRegion",
                CommandType = CommandType.StoredProcedure,
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while (reader.Read())
            {
                lista.Add(Convert.ToString(reader["NOMBRE_REGION"]));
            }
            con.CerrarConexion();

            return lista;

        }
        #endregion
    }
}
