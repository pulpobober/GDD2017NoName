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

                sqlCommand = new SqlCommand("NONAME.rendirViaje");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_chofer", idchofer);
                sqlCommand.Parameters.AddWithValue("@id_turno", id_turno);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha);

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

                sqlCommand = new SqlCommand("NONAME.rendirViaje");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_chofer", idchofer);
                sqlCommand.Parameters.AddWithValue("@id_turno", id_turno);
                sqlCommand.Parameters.AddWithValue("@fecha", fecha);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                return double.Parse(dataTableListado.Rows[0][1].ToString());
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
