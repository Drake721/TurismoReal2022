using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Comuna
    {
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_Comuna ce = new CE_Comuna();

        #region IDCOMUNA
        public int ID_COMUNA(string NOMBRE_COMUNA)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_C_IDCOMUNA",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@NOMBRE_COMUNA", NOMBRE_COMUNA);
            object valor = com.ExecuteScalar();
            int ID_COMUNA = (int)valor;
            con.CerrarConexion();

            return ID_COMUNA;
        }
        #endregion

        #region NombreComuna
        public CE_Comuna NOMBRE_COMUNA(int ID_COMUNA)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_C_CargarNombreComuna", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@ID_COMUNA", SqlDbType.Int).Value = ID_COMUNA;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.NOMBRE_COMUNA = Convert.ToString(row[0]);


            return ce;
        }
        #endregion

        #region listarComuna
        public List<string> ObtenerCargos()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_C_CargarComunas",
                CommandType = CommandType.StoredProcedure,
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while (reader.Read())
            {
                lista.Add(Convert.ToString(reader["NOMBRE_COMUNA"]));
            }
            con.CerrarConexion();

            return lista;

        }
        #endregion  
    }
}
