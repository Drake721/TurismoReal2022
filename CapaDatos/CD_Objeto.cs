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
    public class CD_Objeto
    {
        private readonly CD_Conexion con = new CD_Conexion();
        private readonly CE_Objeto ce = new CE_Objeto();

        //CRUD USUARIOS

        #region insert
        public void CD_Insertar(CE_Objeto objeto)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_insertarObj",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@codigo_objeto", objeto.Codigo_objeto);
            com.Parameters.AddWithValue("@nombre_objeto", objeto.Nombre_objeto);
            com.Parameters.AddWithValue("@cant_objeto", objeto.Cant_objeto);
            com.Parameters.AddWithValue("@valor", objeto.Valor);           
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region consulta
        public CE_Objeto CD_Consulta(int id_obj)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_consultarObj", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("id_obj", SqlDbType.Int).Value = id_obj;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Codigo_objeto = Convert.ToInt32(row[1]);
            ce.Nombre_objeto = Convert.ToString(row[2]);
            ce.Cant_objeto = Convert.ToInt32(row[3]);
            ce.Valor = Convert.ToInt32(row[4]);
            return ce;
        }
        #endregion

        #region Eliminar
        public void CD_Eliminar(CE_Objeto objeto)
        {
            SqlCommand com = new SqlCommand
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_eliminarObj",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_obj", objeto.Id_obj);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region Actualizar Datos
        public void CD_ActualizarDatos(CE_Objeto objeto)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_U_actualizarObj",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_obj", objeto.Id_obj);
            com.Parameters.AddWithValue("@codigo_objeto", objeto.Codigo_objeto);
            com.Parameters.AddWithValue("@nombre_objeto", objeto.Nombre_objeto);
            com.Parameters.AddWithValue("@cant_objeto", objeto.Cant_objeto);
            com.Parameters.AddWithValue("@valor", objeto.Valor);

            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();

        }


        #endregion

        //vista objetos lista

        #region cargar objetos
        public DataTable CargarObjeto()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_U_cargarObjetos", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion

        
        #region idObjeto
        public int id_Objeto(string nombre_objeto)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_C_idObj",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@nombre_objeto", nombre_objeto);
            object valor = com.ExecuteScalar();
            int id_obj = (int)valor;
            con.CerrarConexion();

            return id_obj;
        }
        #endregion

        #region NombreObjeto
        public CE_Objeto nombres(int id_obj)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_C_cargarnombreObj", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id_obj", SqlDbType.Int).Value = id_obj;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Nombre_objeto = Convert.ToString(row[0]);

            return ce;
        }
        #endregion



    }
}
