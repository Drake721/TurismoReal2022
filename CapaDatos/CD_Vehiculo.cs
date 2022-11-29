using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Vehiculo
    {
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_Vehiculo ce = new CE_Vehiculo();


        #region insert
        public void CD_Insertar(CE_Vehiculo vehiculo)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_V_insertar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@patente", vehiculo.Patente);
            com.Parameters.AddWithValue("@codigo", vehiculo.Codigo);
            com.Parameters.AddWithValue("@descripcion", vehiculo.Descripcion);
            com.Parameters.AddWithValue("@id_usuario", vehiculo.Id_usuario);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region consulta
        public CE_Vehiculo CD_Consulta(int id_vehiculo)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_V_consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("id_vehiculo", SqlDbType.Int).Value = id_vehiculo;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Patente = Convert.ToString(row[1]);
            ce.Codigo = Convert.ToInt32(row[2]);
            ce.Descripcion = Convert.ToString(row[3]);
            ce.Id_usuario = Convert.ToInt32(row[4]);
            return ce;
        }
        #endregion

        #region Eliminar
        public void CD_Eliminar(CE_Vehiculo vehiculo)
        {
            SqlCommand com = new SqlCommand
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_V_eliminar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_vehiculo", vehiculo.Id_vehiculo);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region Actualizar Datos
        public void CD_ActualizarDatos(CE_Vehiculo vehiculo)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_V_actualizar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_vehiculo", vehiculo.Id_vehiculo);
            com.Parameters.AddWithValue("@patente", vehiculo.Patente);
            com.Parameters.AddWithValue("@codigo", vehiculo.Codigo);
            com.Parameters.AddWithValue("@descripcion", vehiculo.Descripcion);
            com.Parameters.AddWithValue("@id_usuario", vehiculo.Id_usuario);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();

        }
        #endregion

        #region cargar vehiculos
        public DataTable Cargarvehiculos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_V_cargarVehiculo", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion

        #region idvehiculo
        public int id_vehiculo(string patente)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_V_idvehiculo",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@patente", patente);
            object valor = com.ExecuteScalar();
            int id_vehiculo = (int)valor;
            con.CerrarConexion();

            return id_vehiculo;
        }
        #endregion
        #region patente
        public CE_Vehiculo patente(int id_vehiculo)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_V_cargarPatente", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id_vehiculo", SqlDbType.Int).Value = id_vehiculo;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Patente = Convert.ToString(row[0]);

            return ce;
        }
        #endregion

        #region listarvehiculo
        public List<string> Obtenervehiculo()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_V_cargarVehiculo",
                CommandType = CommandType.StoredProcedure,
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while (reader.Read())
            {
                lista.Add(Convert.ToString(reader["patente"]));
            }
            con.CerrarConexion();

            return lista;

        }
        #endregion


    }
}
