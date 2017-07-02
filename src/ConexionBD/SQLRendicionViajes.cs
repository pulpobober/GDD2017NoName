using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.ConexionBD
{
    class SQLRendicionViajes:ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();
        
        public static DataTable previsualizarConDetalle(int idchofer, int id_turno, DateTime fecha)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sp_detelle_rendicion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario", idchofer);
                sqlCommand.Parameters.AddWithValue("@id_turno", id_turno);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha.Date);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                return dataTableListado;
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
        public static void rendir(int id_rendicion, int idchofer, int id_turno, DateTime fecha)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sp_confirmacion_rendicion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nro_rendicion", id_rendicion);
                sqlCommand.Parameters.AddWithValue("@id_usuario", idchofer);
                sqlCommand.Parameters.AddWithValue("@id_turno", id_turno);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha.Date);

                sqlCommand.ExecuteReader();
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

        public static DataTable rendirElTotal(int idchofer, int id_turno, DateTime fecha)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sp_importe_rendicion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario", idchofer);
                sqlCommand.Parameters.AddWithValue("@id_turno", id_turno);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha.Date);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                return dataTableListado;
                //return double.Parse(dataTableListado.Rows[0][0].ToString());
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
