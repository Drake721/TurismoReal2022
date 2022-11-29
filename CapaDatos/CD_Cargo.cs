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


        #region insert
        public void CD_Insertar(CE_Cargo cargo)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_C_insertar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@codigo", cargo.Codigo);
            com.Parameters.AddWithValue("@nombrecargo", cargo.Nombrecargo);
            com.Parameters.AddWithValue("@descripcion", cargo.Descripcion);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region consulta
        public CE_Cargo CD_Consulta(int id)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_C_consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("id", SqlDbType.Int).Value = id;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Codigo = Convert.ToInt32(row[1]);
            ce.Nombrecargo = Convert.ToString(row[2]);
            ce.Descripcion = Convert.ToString(row[3]);
            return ce;
        }
        #endregion

        #region Eliminar
        public void CD_Eliminar(CE_Cargo cargo)
        {
            SqlCommand com = new SqlCommand
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_C_eliminar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id", cargo.Id);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region Actualizar Datos
        public void CD_ActualizarDatos(CE_Cargo cargo)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_C_actualizar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id", cargo.Id);
            com.Parameters.AddWithValue("@codigo", cargo.Codigo);
            com.Parameters.AddWithValue("@nombrecargo", cargo.Nombrecargo);
            com.Parameters.AddWithValue("@descripcion", cargo.Descripcion);           
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();

        }       
        #endregion
        
        #region cargar cargos
        public DataTable CargarCargos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_C_cargarcargos", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion
        
        #region IDCARGO
        public int ID(string nombrecargo)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_C_idcargo",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@nombrecargo", nombrecargo);
            object valor = com.ExecuteScalar();
            int ID = (int)valor;
            con.CerrarConexion();

            return ID;
        }
        #endregion
        #region NombreCargo
        public CE_Cargo nombrecargo(int ID)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_C_cargarnombrecargo", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@idcargo", SqlDbType.Int).Value = ID;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Nombrecargo = Convert.ToString(row[0]);


            return ce;
        }
        #endregion

        #region listarCargos
        public List<string> ObtenerCargos()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection =con.AbrirConexion(),
                CommandText = "SP_C_cargarcargos",
                CommandType = CommandType.StoredProcedure,
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while (reader.Read())
            {
                lista.Add(Convert.ToString(reader["nombrecargo"]));
            }
            con.CerrarConexion();

            return lista;

        }
        #endregion  
    }

}
