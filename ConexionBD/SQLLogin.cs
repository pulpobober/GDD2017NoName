using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.ConexionBD
{
    public class SQLLogin : ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();

        public static int verificarLogin(string usuario, string contrasena)
        {
            int resultado = -1;

            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_login_usuario");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nombre_de_usuario", usuario);
                sqlCommand.Parameters.AddWithValue("@contrasena", contrasena);

                resultado = sqlCommand.ExecuteNonQuery();
                return resultado;

            }
            catch (Exception ex)
            {
                //Manejar errores
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }
    }
}
