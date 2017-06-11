using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.ConexionBD
{
    public class SQLListadoEstadistico : ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();

        //Charlar con juli a ver si lo hago yo con un select desde aca o con un stored procedure

        public static DataTable choferesConMasRecaudacion(int anio, int trimestre)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.choferes_con_mas_recaudacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@anio", anio);
                sqlCommand.Parameters.AddWithValue("@trimestre", trimestre);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                return dataTableListado;
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

        public static DataTable choferesConElViajeMasLargoRealizado(int anio, int trimestre)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.choferes_con_viaje_mas_largo");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@anio", anio);
                sqlCommand.Parameters.AddWithValue("@trimestre", trimestre);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                return dataTableListado;

            }
            catch (Exception ex)
            {
                //hacer algo con las exepciones
                return null;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static DataTable clientesConMayorConsumo(int anio, int trimestre)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.clientes_con_mayor_consumo");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@anio", anio);
                sqlCommand.Parameters.AddWithValue("@trimestre", trimestre);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                return dataTableListado;

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

        public static DataTable ClienteQueUtilizoMasVecesElMismoAutomovil(int anio, int trimestre)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.cliente_que_utilizo_automovil");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@anio", anio);
                sqlCommand.Parameters.AddWithValue("@trimestre", trimestre);

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableListado = new DataTable();
                dataTableListado.Load(sqlReader);
                return dataTableListado;

            }
            catch (Exception ex)
            {
                //hacer algo con las exepciones
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
