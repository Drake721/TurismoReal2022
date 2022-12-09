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
    public class CD_Inventario
    {

        private readonly CD_Conexion con = new CD_Conexion();
        private readonly CE_Inventario_DPTO ce = new CE_Inventario_DPTO();

        //CRUD Depatamentos

        #region insert
        public void CD_Insertar(CE_Inventario_DPTO Inventario)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_I_insertar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_dpto", Inventario.Id_dpto);
            com.Parameters.AddWithValue("@id_objeto", Inventario.Id_objeto);
            com.Parameters.AddWithValue("@nombre_inventario", Inventario.Nombre_inventario);            
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region consulta
        public CE_Inventario_DPTO CD_Consulta(int id_inv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_I_consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("id_inv", SqlDbType.Int).Value = id_inv;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Id_dpto = Convert.ToInt32(row[1]);
            ce.Id_objeto = Convert.ToInt32(row[2]);
            ce.Nombre_inventario = Convert.ToString(row[3]);
            return ce;
        }
        #endregion

        #region Eliminar
        public void CD_Eliminar(CE_Inventario_DPTO Inventario)
        {
            SqlCommand com = new SqlCommand
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_I_eliminar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@Id_inv", Inventario.Id_inv);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }



        #endregion

        #region Actualizar Datos
        public void CD_ActualizarDatos(CE_Inventario_DPTO Inventario)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_I_actualizar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_inv", Inventario.Id_inv);
            com.Parameters.AddWithValue("@id_dpto", Inventario.Id_dpto);
            com.Parameters.AddWithValue("@id_objeto", Inventario.Id_objeto);
            com.Parameters.AddWithValue("@nombre_inventario", Inventario.Nombre_inventario);
           
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();

        }

        #endregion

        //vista Despartamentos lista
        #region cargar Inventario
        public DataTable CargarInventario()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_I_cargarinventarios", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion

        #region cargar Inventario filtrado
        public DataTable CargarInventariofil(int Id_dpto)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_I_cargarinventario", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@Id_dpto", SqlDbType.Int).Value = Id_dpto;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion



        #region ID
        public int id_inv(string nombre_inventario)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_I_id_inv",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@nombre_inventario", nombre_inventario);
            object valor = com.ExecuteScalar();
            int id_inv = (int)valor;
            con.CerrarConexion();

            return id_inv;
        }
        #endregion

        #region Nombre
        public CE_Inventario_DPTO nombre_inv(int id_inv)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_I_cargarnombreobjeto", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id_inv", SqlDbType.Int).Value = id_inv;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Nombre_inventario = Convert.ToString(row[0]);

            return ce;
        }
        #endregion

        #region listar
        public List<string> ObtenerDpto()
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_C_cargarDpto",
                CommandType = CommandType.StoredProcedure,
            };
            SqlDataReader reader = com.ExecuteReader();
            List<string> lista = new List<string>();
            while (reader.Read())
            {
                //if(nombrecargo == chofer) {             
                lista.Add(Convert.ToString(reader["nombre_dpto"]));
                //}
            }
            con.CerrarConexion();

            return lista;

        }
        #endregion  

        /*#region Buscar 
        public DataTable Buscar(string buscar)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_D_Buscar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@buscar", SqlDbType.VarChar).Value = buscar;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion*/

    }
}
