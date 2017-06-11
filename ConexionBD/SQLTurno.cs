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
                sqlCommand = new SqlCommand("NONAME.sproc_turno_alta");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@hora_inicio", unTurno.hora_inicio);
                sqlCommand.Parameters.AddWithValue("@hora_fin", unTurno.hora_fin);
                sqlCommand.Parameters.AddWithValue("@descripcion", unTurno.descripcion);
                sqlCommand.Parameters.AddWithValue("@valor_km", unTurno.valor_km); 
                sqlCommand.Parameters.AddWithValue("@precio_base", unTurno.precio_base);
                sqlCommand.Parameters.AddWithValue("@habilitado", unTurno.habilitado);
              
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
                sqlCommand.CommandText = "SELECT id_turno, hora_inicio, hora_fin, descripcion, valor_km, precio_base, habilitado FROM NONAME.Turno";
                sqlCommand.CommandType = CommandType.Text;
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


        public static DataTable filtarTurnos(Turno unTurno)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_turno, hora_inicio, hora_fin, descripcion, valor_km, precio_base, habilitado FROM NONAME.Turno WHERE descripcion = '" + unTurno.descripcion + "'";
                sqlCommand.CommandType = CommandType.Text;
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
                sqlCommand = new SqlCommand("NONAME.sproc_turno_modificacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_turno", unTurno.id_turno);
                sqlCommand.Parameters.AddWithValue("@hora_inicio", unTurno.hora_inicio);
                sqlCommand.Parameters.AddWithValue("@hora_fin", unTurno.hora_fin);
                sqlCommand.Parameters.AddWithValue("@descripcion", unTurno.descripcion);
                sqlCommand.Parameters.AddWithValue("@valor_km", unTurno.valor_km);
                sqlCommand.Parameters.AddWithValue("@precio_base", unTurno.precio_base);
                sqlCommand.Parameters.AddWithValue("@habilitado", unTurno.habilitado);

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
                sqlCommand = new SqlCommand("NONAME.sproc_turno_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_turno", unTurno.id_turno);

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
    }
}
