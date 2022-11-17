using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Cargo
    {
        readonly CD_Conexion con =new CD_Conexion();
        readonly CE_Cargo ce = new CE_Cargo();

        #region IDCARGO
        public int ID(string NOMBRECARGO)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_C_IDCARGO",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@NombreCargo", NOMBRECARGO);
            object valor = com.ExecuteScalar();
            int ID = (int)valor;
            con.CerrarConexion();

            return ID;
        }
        #endregion
        #region NombreCargo
        public CE_Cargo NOMBRECARGO(int ID)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_C_CargarNombreCargo", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IDCARGO", SqlDbType.Int).Value = ID;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.NOMBRECARGO = Convert.ToString(row[0]);


            return ce;
        }
        #endregion

        #region listarCargos
        public List<string> ObtenerCargos()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection =con.AbrirConexion(),
                CommandText = "SP_C_CargarCargos",
                CommandType = CommandType.StoredProcedure,
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while (reader.Read())
            {
                lista.Add(Convert.ToString(reader["NOMBRECARGO"]));
            }
            con.CerrarConexion();

            return lista;

        }
        #endregion  
    }

}
