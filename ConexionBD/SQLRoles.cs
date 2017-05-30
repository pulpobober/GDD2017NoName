using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberFrba.Objetos;

namespace UberFrba.ConexionBD
{
    public class SQLRoles:ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();

        public static void insertarRol(Rol unRol)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.alta_rol");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nombre", unRol.nombre);
           //     sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);
                sqlCommand.Parameters.AddWithValue("@habilitado", unRol.estado);
                //int id = 
                /*
                                 parameter = new SqlParameter("@nombre", SqlDbType.NVarChar, 50);
                parameter.Value = nombre;
                parameters.Add(parameter);

                parameter = new SqlParameter("@inhabilitado", SqlDbType.Bit);
                parameter.Value = !habilitado;
                parameters.Add(parameter);
                int id;

                id = int.Parse((AdaptadorSQL.SQLHelper_ExecuteScalar("NONAME.alta_Rol", parameters)).ToString());

                // Como barro un map?
                foreach (KeyValuePair<int, bool> funcionabilidad in funciones)
                {


                    parameters.Clear();

                    parameter = new SqlParameter("@idRol", SqlDbType.Int);
                    parameter.Value = id;
                    parameters.Add(parameter);

                    parameter = new SqlParameter("@idFuncionabilidad", SqlDbType.Int);
                    parameter.Value = funcionabilidad.Key;
                    parameters.Add(parameter);

                    if (funcionabilidad.Value == true) AdaptadorSQL.SQLHelper_ExecuteNonQuery("NONAME.alta_funcionabiliad_x_rol", parameters);
                    else AdaptadorSQL.SQLHelper_ExecuteNonQuery("NONAME.baja_funcionablilida_x_rol", parameters);

                }

                 */


                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Manejar errores

            }
            finally
            {
                desconectar();
            }
        }


        public static DataTable obtenerTodosLosRoles()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.obtener_todos_los_roles");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.ExecuteNonQuery();

                DataTable dataTableRoles = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTableRoles);
                return dataTableRoles;

            }
            catch (Exception ex)
            {
                //hacer algo con las exepciones
                return null;
            }
            finally
            {
                desconectar();
            }
        }

        public static void modificarRol(Rol unRol)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.modificar_rol");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nombre", unRol.nombre);
                //sqlCommand.Parameters.AddWithValue("@apellido", clie.apellido);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //manejar exepciones
            }
            finally
            {
                desconectar();
            }
        }

        public static void eliminarRol(Rol unRol)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.baja_rol");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nombre", unRol.nombre);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //manejar exepciones
            }
            finally
            {
                desconectar();
            }
        }


        public static DataTable obtenerTodasLasFuncionalidades()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.obtener_todas_las_funcionalidades");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.ExecuteNonQuery();

                DataTable dataTableFuncionalidades = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTableFuncionalidades);
                return dataTableFuncionalidades;

            }
            catch (Exception ex)
            {
                //hacer algo con las exepciones
                return null;
            }
            finally
            {
                desconectar();
            }
        }
    }
}


