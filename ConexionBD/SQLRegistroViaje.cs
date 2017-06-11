using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.ConexionBD
{
    public class SQLRegistroViaje : ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();

        public static void registrarViaje(int id_chofer, int id_auto, int id_turno, int cantKM, DateTime fechaYHoraInicio, DateTime fechaYHoraFinal, int id_cliente)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sproc_registrar_viaje");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_chofer", id_chofer);
                sqlCommand.Parameters.AddWithValue("@id_auto", id_auto);
                sqlCommand.Parameters.AddWithValue("@id_turno", id_turno);
                sqlCommand.Parameters.AddWithValue("@cant_Km", cantKM);
                sqlCommand.Parameters.AddWithValue("@fecha_inicio", fechaYHoraInicio);
                sqlCommand.Parameters.AddWithValue("@fecha_final", fechaYHoraFinal);
                sqlCommand.Parameters.AddWithValue("@id_cliente", id_cliente);

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
    }
}
