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

        public static DataTable choferesConMasRecaudacion(int anio, int trimestre)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sproc_top5_choferesConMayorRecaudacion");
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

                sqlCommand = new SqlCommand("NONAME.sproc_top5_choferesConViajeMasLargoRealizado");
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

        public static DataTable clientesConMayorConsumo(int anio, int trimestre)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sproc_top5_clientesConMayorConsumo");
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

                sqlCommand = new SqlCommand("NONAME.sproc_top1_clienteQueUtilizoMasVecesMismoAuto");
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


    }
}
