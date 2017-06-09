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
    public class SQLTurno : ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();

        public static void insertarTurno(Turno unTurno)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_rol_alta");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

      //          sqlCommand.Parameters.AddWithValue("@tipo", unTurno.nombre);
       //         sqlCommand.Parameters.AddWithValue("@habilitado", unTurno.estado);
               // DataTable columna = unTurno.tablaFuncionalidades.DefaultView.ToTable(false, unTurno.tablaFuncionalidades.Columns[0].ColumnName);
               // sqlCommand.Parameters.AddWithValue("ids_funciones", columna);
               sqlCommand.ExecuteNonQuery();

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


        public static DataTable obtenerTodosLosTurnos()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_rol, tipo, habilitado FROM NONAME.Turno";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableTurnos = new DataTable();
                dataTableTurnos.Load(sqlReader);
                return dataTableTurnos;
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

       

        public static void modificarTurno(Turno unTurno)
        {

            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_rol_modificacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

          //      sqlCommand.Parameters.AddWithValue("@id_rol", unTurno.id_rol);
          //      sqlCommand.Parameters.AddWithValue("@tipo", unTurno.nombre);
            //    sqlCommand.Parameters.AddWithValue("@habilitado", unTurno.estado);
           //     DataTable columna = unTurno.tablaFuncionalidades.DefaultView.ToTable(false, unTurno.tablaFuncionalidades.Columns[0].ColumnName);
         //       sqlCommand.Parameters.AddWithValue("ids_funciones", columna);
                sqlCommand.ExecuteNonQuery();

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

        public static void eliminarTurno(Turno unTurno)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_rol_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

          //      sqlCommand.Parameters.AddWithValue("@id_rol", unTurno.id_rol);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //manejar exepciones
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
                DataTable dataTableTurnos = new DataTable();
                dataTableTurnos.Load(sqlReader);
                return dataTableTurnos;
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

        public static DataTable obtenerTodasLasFuncionalidadesHabilitadasDelTurno(int id_rol)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT f.id_funcion, f.descripcion FROM NONAME.Funcion_Turno fr Join NONAME.Funcion f on f.id_funcion = fr.id_funcion, NONAME.Turno r WHERE r.id_rol = fr.id_rol AND r.id_rol =" + id_rol.ToString();
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableTurnos = new DataTable();
                dataTableTurnos.Load(sqlReader);
                return dataTableTurnos;
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
