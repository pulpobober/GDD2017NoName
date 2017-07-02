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

        public static string registrarViaje(int id_chofer, int id_auto, int id_turno, int cantKM, DateTime fechaYHoraInicio, DateTime fechaYHoraFinal, int id_cliente)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sp_RegistroViaje");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_chofer", id_chofer);
                sqlCommand.Parameters.AddWithValue("@id_auto", id_auto);
                sqlCommand.Parameters.AddWithValue("@id_turno", id_turno);
                sqlCommand.Parameters.AddWithValue("@cant_km", cantKM);
                sqlCommand.Parameters.AddWithValue("@fecha_inicio", fechaYHoraInicio);
                sqlCommand.Parameters.AddWithValue("@fecha_fin", fechaYHoraFinal);
                sqlCommand.Parameters.AddWithValue("@id_cliente", id_cliente);


                int response = sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Viaje registrado";
                }
                else
                {
                    return "Fallo al registrar el viaje";
                }
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
