using CapaEntidad;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace CapaDatos
{
    public class CD_Mantencion
    { 
        readonly CD_Conexion con = new CD_Conexion();
        readonly CE_MANTENIMIENTO ce = new CE_MANTENIMIENTO();

        #region insert
        public void CD_Insertar(CE_MANTENIMIENTO mantenimiento)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_M_insertar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_dpto", mantenimiento.Id_dpto);
            com.Parameters.AddWithValue("@nombre_mant", mantenimiento.Nombre_mant);
            com.Parameters.AddWithValue("@descripcion_mant", mantenimiento.Descripcion_mant);
            com.Parameters.AddWithValue("@fecha_inicio", mantenimiento.Fecha_inicio);
            com.Parameters.AddWithValue("@fecha_termino", mantenimiento.Fecha_termino);
            com.Parameters.AddWithValue("@DISPONIBILIDAD", mantenimiento.Disponibilidad);
            com.Parameters.AddWithValue("@costo_mantencion", mantenimiento.Costo_mantencion);
 
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();
        }
        #endregion

        #region consulta
        public CE_MANTENIMIENTO CD_Consulta(int id_mant)
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_M_consultar", con.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("id_mant", SqlDbType.Int).Value = id_mant;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt;
            dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            ce.Id_dpto = Convert.ToInt32(row[1]);
            ce.Nombre_mant = Convert.ToString(row[2]);
            ce.Descripcion_mant = Convert.ToString(row[3]);
            ce.Fecha_inicio = Convert.ToDateTime(row[4]);
            ce.Fecha_termino = Convert.ToDateTime(row[5]);
            ce.Disponibilidad = Convert.ToInt32(row[6]);
            ce.Costo_mantencion = Convert.ToInt32(row[7]);
            return ce;
        }
        #endregion

        #region Actualizar Datos
        public void CD_ActualizarDatos(CE_MANTENIMIENTO mantenimiento)
        {
            SqlCommand com = new SqlCommand()
            {
                Connection = con.AbrirConexion(),
                CommandText = "SP_M_actualizar",
                CommandType = CommandType.StoredProcedure,
            };
            com.Parameters.AddWithValue("@id_mant", mantenimiento.Id_mant);
            com.Parameters.AddWithValue("@id_dpto", mantenimiento.Id_dpto);
            com.Parameters.AddWithValue("@nombre_mant", mantenimiento.Nombre_mant);
            com.Parameters.AddWithValue("@descripcion_mant", mantenimiento.Descripcion_mant);
            com.Parameters.AddWithValue("@fecha_inicio", mantenimiento.Fecha_inicio);
            com.Parameters.AddWithValue("@fecha_termino", mantenimiento.Fecha_termino);
            com.Parameters.AddWithValue("@DISPONIBILIDAD", mantenimiento.Disponibilidad);
            com.Parameters.AddWithValue("@costo_mantencion", mantenimiento.Costo_mantencion);
            com.ExecuteNonQuery();
            com.Parameters.Clear();
            con.CerrarConexion();

        }

        #endregion

        #region cargar mantenimientos
        public DataTable CargarMantencion()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_M_cargarManten", con.AbrirConexion());
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
