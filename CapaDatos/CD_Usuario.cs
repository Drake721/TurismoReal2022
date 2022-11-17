using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using System;

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
                CommandText = "SP_U_Insertar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@EMAIL", Usuario.EMAIL);
            com.Parameters.AddWithValue("@CLAVE", Usuario.CLAVE);
            com.Parameters.AddWithValue("@CELULAR", Usuario.CELULAR);
            com.Parameters.AddWithValue("@RUT", Usuario.RUT);
            com.Parameters.AddWithValue("@NOMBRES", Usuario.NOMBRES);
            com.Parameters.AddWithValue("@APELLIDOPATERNO", Usuario.APELLIDOPATERNO);
            com.Parameters.AddWithValue("@APELLIDOMATERNO", Usuario.APELLIDOMATERNO);
            com.Parameters.AddWithValue("@IMG", Usuario.IMG);
            com.Parameters.AddWithValue("@IDCARGO", Usuario.IDCARGO);
            com.Parameters.AddWithValue("@PATRON", Usuario.PATRON);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion
        #region consulta
        public CE_Usuario CD_Consulta(int ID_USUARIO)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_Consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("ID_USUARIO", SqlDbType.Int).Value = ID_USUARIO;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.EMAIL = Convert.ToString(row[1]);
            ce.CELULAR = Convert.ToInt32(row[3]);
            ce.RUT = Convert.ToString(row[4]);
            ce.NOMBRES = Convert.ToString(row[5]);
            ce.APELLIDOPATERNO = Convert.ToString(row[6]);
            ce.APELLIDOMATERNO = Convert.ToString(row[7]);
            ce.IMG = (byte[])row[8];
            ce.IDCARGO = Convert.ToInt32(row[9]);
            return ce;
        }
        #endregion
        #region Eliminar
        public void CD_Eliminar(CE_Usuario Usuario)
        {
            SqlCommand com = new SqlCommand
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_Eliminar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@ID_USUARIO", Usuario.ID_USUARIO);
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
                CommandText = "SP_U_Actualizar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@ID_Usuario", Usuario.ID_USUARIO);
            com.Parameters.AddWithValue("@EMAIL", Usuario.EMAIL);
            com.Parameters.AddWithValue("@CELULAR", Usuario.CELULAR);
            com.Parameters.AddWithValue("@RUT", Usuario.RUT);
            com.Parameters.AddWithValue("@NOMBRES", Usuario.NOMBRES);
            com.Parameters.AddWithValue("@APELLIDOPATERNO", Usuario.APELLIDOPATERNO);
            com.Parameters.AddWithValue("@APELLIDOMATERNO", Usuario.APELLIDOMATERNO);
            com.Parameters.AddWithValue("@IDCARGO", Usuario.IDCARGO);
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
                CommandText = "SP_U_ActualizarCLAVE",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("ID_USUARIO", Usuario.ID_USUARIO);
            com.Parameters.AddWithValue("@CLAVE", Usuario.CLAVE);
            com.Parameters.AddWithValue("@PATRON", Usuario.PATRON);
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
                CommandText = "SP_U_ActualizarIMG",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("ID_USUARIO", Usuario.ID_USUARIO);
            com.Parameters.AddWithValue("@IMG", Usuario.IMG);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        //vista usuarios lista
        #region cargar usuarios
        public DataTable CargarUsuarios()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_CargarUsuarios", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion
    }
}
