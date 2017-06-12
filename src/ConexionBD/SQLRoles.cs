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

        public static string insertarRol(Rol unRol)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_rol_alta");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@tipo", unRol.nombre);
                sqlCommand.Parameters.AddWithValue("@habilitado", unRol.estado);
                DataTable columna = unRol.tablaFuncionalidades.DefaultView.ToTable(false, unRol.tablaFuncionalidades.Columns[0].ColumnName);
                sqlCommand.Parameters.AddWithValue("ids_funciones", columna);
                int response=sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Rol dado de alta correctamente";
                }
                else
                {
                    return "Fallo al dar de alta el rol: " + unRol.nombre;
                }

            }
            catch (Exception ex)
            {
                return "Fallo al dar de alta el rol: " + unRol.nombre;
                throw ex;
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
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_rol, tipo, habilitado FROM NONAME.Rol";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableRoles = new DataTable();
                dataTableRoles.Load(sqlReader);
                return dataTableRoles;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

       

        public static string modificarRol(Rol unRol)
        {

            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_rol_modificacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_rol", unRol.id_rol);
                sqlCommand.Parameters.AddWithValue("@tipo", unRol.nombre);
                sqlCommand.Parameters.AddWithValue("@habilitado", unRol.estado);
                DataTable columna = unRol.tablaFuncionalidades.DefaultView.ToTable(false, unRol.tablaFuncionalidades.Columns[0].ColumnName);
                sqlCommand.Parameters.AddWithValue("ids_funciones", columna);
                int response=sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Rol modificado exitosamente";
                }
                else
                {
                    return "Fallo al modificar el rol: " + unRol.nombre;
                }

            }
            catch (Exception ex)
            {
                //Manejar errores
                return "Fallo al modificar el rol: " + unRol.nombre;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static string eliminarRol(Rol unRol)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_rol_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_rol", unRol.id_rol);

                int response=sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Rol dado de baja exitosamente";
                }
                else
                {
                    return "Fallo al dar de baja el rol: " + unRol.nombre;
                }
            }
            catch (Exception ex)
            {
                //manejar exepciones
                return "Fallo al dar de baja el rol: " + unRol.nombre;
                throw ex;
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
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_funcion, descripcion FROM NONAME.Funcion";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableRoles = new DataTable();
                dataTableRoles.Load(sqlReader);
                return dataTableRoles;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static DataTable obtenerTodasLasFuncionalidadesHabilitadasDelRol(int id_rol)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT f.id_funcion, f.descripcion FROM NONAME.Funcion_Rol fr Join NONAME.Funcion f on f.id_funcion = fr.id_funcion, NONAME.Rol r WHERE r.id_rol = fr.id_rol AND r.id_rol =" + id_rol.ToString();
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableRoles = new DataTable();
                dataTableRoles.Load(sqlReader);
                return dataTableRoles;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }
    }
}
