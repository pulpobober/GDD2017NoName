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
        public static DataTable rendirConDetalle(int idchofer, int id_turno, DateTime fecha)
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

        public static double rendirElTotal(int idchofer, int id_turno, DateTime fecha)
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
                return double.Parse(dataTableListado.Rows[0][0].ToString());
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
