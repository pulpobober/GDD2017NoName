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
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_login_usuario");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nombre_de_usuario", usuario);
                sqlCommand.Parameters.AddWithValue("@contrasena", contrasena);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableLogin = new DataTable();
                dataTableLogin.Load(sqlReader);
                return int.Parse(dataTableLogin.Rows[0][1].ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static DataTable obtenerRolesUsuario(string nombre_usuario)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT u.id_usuario, ro.id_rol ,ro.tipo FROM NONAME.Rol_Usuario r join NONAME.Usuario u on r.id_usuario = u.id_usuario, NONAME.Rol ro WHERE ro.id_rol = r.id_rol And nombre_de_usuario = '" + nombre_usuario+"'";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableRoles = new DataTable();
                dataTableRoles.Load(sqlReader);
                return dataTableRoles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }
    }
}