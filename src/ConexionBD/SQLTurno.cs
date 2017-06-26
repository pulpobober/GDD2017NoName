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

        public static string insertarTurno(Turno unTurno)
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
              
               int response= sqlCommand.ExecuteNonQuery();
               if (response > 0)
               {
                   return "Turno dado de alta correctamente";
               }
               else
               {
                   return "Fallo al dar de alta el turno: " + unTurno.descripcion;
               }
            }
            catch (Exception ex)
            {
                return "Fallo al dar de alta el turno: " + unTurno.descripcion;
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
                sqlCommand.CommandText = "SELECT id_turno, hora_inicio, hora_fin, descripcion, valor_km, precio_base, habilitado FROM NONAME.Turno WHERE descripcion like '%" + unTurno.descripcion + "%'";
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

        public static string modificarTurno(Turno unTurno)
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

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableTurnos = new DataTable();
                dataTableTurnos.Load(sqlReader);
                int response = int.Parse(dataTableTurnos.Rows[0][0].ToString());

                if (response == 1)
                {
                    return "Turno modificado correctamente";
                }
                else {
                    return "El turno se ha modificado pero hubo un problema con la hora ya que se superpone con otro turno";
                }

                //return dataTableTurnos;

              //  int response = sqlCommand.ExecuteNonQuery();
               // if (response > 0)
               // {
               //     return "Turno modificado correctamente";
               // }
               // else
                //{
                //    return "Fallo al modificar el turno: " + unTurno.descripcion;
                //}

            }
            catch (Exception ex)
            {
                return "FALLO POR EXEPCION Fallo al modificar el turno: " + unTurno.descripcion;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static string eliminarTurno(Turno unTurno)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_turno_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_turno", unTurno.id_turno);

                int response = sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Turno dado de baja correctamente";
                }
                else
                {
                    return "Fallo al dar de baja el turno: " + unTurno.descripcion;
                }
            }
            catch (Exception ex)
            {
                return "Fallo al dar de baja el turno: " + unTurno.descripcion;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static DataTable obtenerTodosLosTurnosDelChofer(int id_chofer)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT c.id_turno, descripcion FROM NONAME.Turno t Join NONAME.Auto_Chofer c on c.id_turno = t.id_turno WHERE c.id_chofer = '" + id_chofer + "'";
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

        public static DataTable obtenerHoraInicioYFinDelTurno(int idTurno)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT hora_inicio, hora_fin FROM NONAME.Turno WHERE id_turno = '" + idTurno + "'";
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
    }
}
