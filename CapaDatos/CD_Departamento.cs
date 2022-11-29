using CapaEntidad;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace CapaDatos
{
    public class CD_Departamento
    {
        private readonly CD_Conexion con = new CD_Conexion();
        private readonly CE_Usuario cee = new CE_Usuario();
        private readonly CE_Departamento ce = new CE_Departamento();

        //CRUD Depatamentos

        #region insert
        public void CD_Insertar(CE_Departamento Departamento)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_D_insertar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@NOMBRE_DPTO", Departamento.@NOMBRE_DPTO);
            com.Parameters.AddWithValue("@TARIFA_DIARIA", Departamento.@TARIFA_DIARIA);
            com.Parameters.AddWithValue("@DIRECCION", Departamento.DIRECCION);
            com.Parameters.AddWithValue("@NRO_DPTO", Departamento.NRO_DPTO);
            com.Parameters.AddWithValue("@CAPACIDAD", Departamento.CAPACIDAD);
            com.Parameters.AddWithValue("@ID_COMUNA", Departamento.ID_COMUNA);
            com.Parameters.AddWithValue("@DISPONIBILIDAD", Departamento.DISPONIBILIDAD);
            com.Parameters.AddWithValue("@IMG", Departamento.IMG);
            com.Parameters.AddWithValue("@IMG1", Departamento.IMG1);
            com.Parameters.AddWithValue("@IMG2", Departamento.IMG2);

            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region consulta
        public CE_Departamento CD_Consulta(int ID_DPTO)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_D_consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("ID_DPTO", SqlDbType.Int).Value = ID_DPTO;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.NOMBRE_DPTO = Convert.ToString(row[1]);
            ce.TARIFA_DIARIA = Convert.ToInt32(row[2]);
            ce.DIRECCION = Convert.ToString(row[3]);
            ce.NRO_DPTO = Convert.ToInt32(row[4]);
            ce.CAPACIDAD = Convert.ToInt32(row[5]); 
            ce.ID_COMUNA = Convert.ToInt32(row[6]);
            ce.DISPONIBILIDAD = Convert.ToInt32(row[7]);
            ce.IMG = (byte[])row[8];
            ce.IMG1 = (byte[])row[9];
            ce.IMG2 = (byte[])row[10];
            return ce;
        }
        #endregion

        #region Eliminar
        public void CD_Eliminar(CE_Departamento Departamento)
        {
            SqlCommand com = new SqlCommand
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_D_eliminar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@ID_DPTO", Departamento.@ID_DPTO);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }



        #endregion

        #region Actualizar Datos
        public void CD_ActualizarDatos(CE_Departamento Departamento)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_D_actualizar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@ID_DPTO", Departamento.ID_DPTO);
            com.Parameters.AddWithValue("@NOMBRE_DPTO", Departamento.NOMBRE_DPTO);
            com.Parameters.AddWithValue("@TARIFA_DIARIA", Departamento.TARIFA_DIARIA);
            com.Parameters.AddWithValue("@DIRECCION", Departamento.DIRECCION);
            com.Parameters.AddWithValue("@NRO_DPTO", Departamento.NRO_DPTO);
            com.Parameters.AddWithValue("@CAPACIDAD", Departamento. CAPACIDAD);
            com.Parameters.AddWithValue("@ID_COMUNA", Departamento.ID_COMUNA);
            com.Parameters.AddWithValue("@DISPONIBILIDAD", Departamento.DISPONIBILIDAD);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();

        }
        
        #endregion

        #region Actualizar IMG
        public void CD_ActualizarIMG(CE_Departamento Departamento)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_D_actualizarimg",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("ID_DPTO", Departamento.ID_DPTO);
            com.Parameters.AddWithValue("@IMG", Departamento.IMG);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region Actualizar IMG1
        public void CD_ActualizarIMG1(CE_Departamento Departamento)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_D_actualizarimg1",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("ID_DPTO", Departamento.ID_DPTO);
            com.Parameters.AddWithValue("@IMG1", Departamento.IMG1);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region Actualizar IMG2
        public void CD_ActualizarIMG2(CE_Departamento Departamento)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_D_actualizarimg2",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("ID_DPTO", Departamento.ID_DPTO);
            com.Parameters.AddWithValue("@IMG2", Departamento.IMG2);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region Actualizar Estado
        public void CD_ActualizarEstado(CE_Departamento Dpto)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_MD_actualizarEstado",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("id_dpto", Dpto.ID_DPTO);
            com.Parameters.AddWithValue("@disponibilidad", Dpto.DISPONIBILIDAD);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();

        }


        #endregion

        //vista Despartamentos lista
        #region cargar departamentos
        public DataTable CargarDepartamento()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_D_cargardpto", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            con.CerrarConexion();

            return dt;
        }
        #endregion

        #region IDDPTO
        public int id_dpto(string nombre_dpto)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_D_idDpto",
                CommandType = CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("@nombre_dpto", nombre_dpto);
            object valor = com.ExecuteScalar();
            int id_dpto = (int)valor;
            con.CerrarConexion();

            return id_dpto;
        }
        #endregion
        #region NombreDPTO
        public CE_Departamento nombre_dpto(int id_dpto)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_D_cargarnombreDpto", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@id_dpto", SqlDbType.Int).Value = id_dpto;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.NOMBRE_DPTO = Convert.ToString(row[0]);
            
            return ce;
        }
        #endregion

        #region listarDPTO
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
    }
}
