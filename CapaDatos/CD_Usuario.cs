using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaDatos
{
    public class CD_Usuario
    {
        private readonly CD_Conexion con = new CD_Conexion();
        private readonly CE_Usuario ce = new CE_Usuario();

        //CRUD USUARIOS

        #region insert
        public void CD_Insertar(CE_Usuario Usuario)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_insertar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@email", Usuario.Email);
            com.Parameters.AddWithValue("@clave", Usuario.Clave);
            com.Parameters.AddWithValue("@celular", Usuario.Celular);
            com.Parameters.AddWithValue("@rut", Usuario.Rut);
            com.Parameters.AddWithValue("@nombres", Usuario.Nombres);
            com.Parameters.AddWithValue("@apellidopaterno", Usuario.Apellidopaterno);
            com.Parameters.AddWithValue("@apellidomaterno", Usuario.Apellidomaterno);
            com.Parameters.AddWithValue("@img", Usuario.Img);
            com.Parameters.AddWithValue("@idcargo", Usuario.Idcargo);
            com.Parameters.AddWithValue("@patron", Usuario.Patron);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region consulta
        public CE_Usuario CD_Consulta(int id_usuario)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("id_usuario", SqlDbType.Int).Value = id_usuario;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Email = Convert.ToString(row[1]);
            ce.Celular = Convert.ToInt32(row[3]);
            ce.Rut = Convert.ToString(row[4]);
            ce.Nombres = Convert.ToString(row[5]);
            ce.Apellidopaterno = Convert.ToString(row[6]);
            ce.Apellidomaterno = Convert.ToString(row[7]);
            ce.Img = (byte[])row[8];
            ce.Idcargo = Convert.ToInt32(row[9]);
            return ce;
        }
        #endregion

        #region Eliminar
        public void CD_Eliminar(CE_Usuario Usuario)
        {
            SqlCommand com = new SqlCommand
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_eliminar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_usuario", Usuario.Id_usuario);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region Actualizar Datos
        public void CD_ActualizarDatos(CE_Usuario Usuario)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_actualizar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_usuario", Usuario.Id_usuario);
            com.Parameters.AddWithValue("@email", Usuario.Email);
            com.Parameters.AddWithValue("@celular", Usuario.Celular);
            com.Parameters.AddWithValue("@rut", Usuario.Rut);
            com.Parameters.AddWithValue("@nombres", Usuario.Nombres);
            com.Parameters.AddWithValue("@apellidopaterno", Usuario.Apellidopaterno);
            com.Parameters.AddWithValue("@apellidomaterno", Usuario.Apellidomaterno);
            com.Parameters.AddWithValue("@idcargo", Usuario.Idcargo);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();

        }


        #endregion

        #region Actualizar clave
        public void CD_ActualizarClave(CE_Usuario Usuario)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_actualizarclave",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("id_usuario", Usuario.Id_usuario);
            com.Parameters.AddWithValue("@clave", Usuario.Clave);
            com.Parameters.AddWithValue("@patron", Usuario.Patron);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();

        }


        #endregion

        #region Actualizar IMG
        public void CD_ActualizarIMG(CE_Usuario Usuario)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_actualizarimg",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_usuario", Usuario.Id_usuario);
            com.Parameters.AddWithValue("@img", Usuario.Img);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion
        //vista usuarios lista
        #region cargar usuarios
        public DataTable CargarUsuarios()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_cargarusuarios", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion

        #region login
        public CE_Usuario Logins(string email, string clave)
        {
            string patron = "ENCRIPTA";
            SqlDataAdapter da = new SqlDataAdapter("SP_U_validar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            da.SelectCommand.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
            da.SelectCommand.Parameters.Add("@patron", SqlDbType.VarChar).Value = patron;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                ce.Id_usuario = Convert.ToInt32(row[0]);
                ce.Idcargo = Convert.ToInt32(row[1]);
            }

            return ce;
        }
        #endregion

        #region idUsuario
        public int id_usuario(string nombres)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_idUsuario",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@nombres", nombres);
            object valor = com.ExecuteScalar();
            int id_usuario = (int)valor;
            con.CerrarConexion();

            return id_usuario;
        }
        #endregion
        #region NombreUsuario
        public CE_Usuario nombres(int id_usuario)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_cargarnombreUsuario", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_usuario;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Nombres = Convert.ToString(row[0]);

            return ce;
        }
        #endregion

        #region listarusuario
        public List<string> ObtenerUsuarios()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_cargarUsuario",
                CommandType = CommandType.StoredProcedure,
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while (reader.Read())
            {                    
                    lista.Add(Convert.ToString(reader["nombres, nombrecargo"]));
            }
            con.CerrarConexion();

            return lista;

        }
        #endregion
    }
}
