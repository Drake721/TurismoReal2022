using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;


namespace CapaDatos
{
    public class CD_Conexion
    {
        private readonly SqlConnection con = new SqlConnection("Data Source = DESKTOP-L9LM2CE\\draco; initial catalog=db_turismo_real; integrated security=true;");

        public SqlConnection AbrirConexion()
        {
            if(con.State == ConnectionState.Closed)
                con.Open();
            return con;
         
        }
        public SqlConnection CerrarConexion()
        {
            if(con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}
/*DESKTOP - L9LM2CE\draco.DB_departamento_Turismo_Real2022.*/