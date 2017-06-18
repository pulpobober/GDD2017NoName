using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using UberFrba.Objetos;

namespace UberFrba.ConexionBD
{
    public class SQLChofer : ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();


        public static string insertarChofer(Chofer chofer)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sproc_chofer_alta");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@nombre", chofer.nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", chofer.apellido);
                sqlCommand.Parameters.AddWithValue("@usuario_dni", chofer.dni);
                sqlCommand.Parameters.AddWithValue("@mail", chofer.mail);
                sqlCommand.Parameters.AddWithValue("@telefono", chofer.telefono);
                sqlCommand.Parameters.AddWithValue("@direccion", chofer.direccion);
                sqlCommand.Parameters.AddWithValue("@fecha_nacimiento", chofer.fechaNacimiento);

               int result=sqlCommand.ExecuteNonQuery();
               if (result > 0)
               {
                   return "Chofer dado de alta exitosamente";
               }
               else
               {
                   return "Fallo al dar de alta un el chofer: " + chofer.nombre + " " + chofer.apellido;
               }

            }
            catch (Exception ex)
            {
                return "Fallo al dar de alta un el chofer: " + chofer.nombre + " " + chofer.apellido;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static DataTable filtrarChoferes(Chofer chofer)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, fecha_nacimiento FROM NONAME.Chofer join NONAME.Usuario on id_Chofer = id_usuario WHERE " + (String.IsNullOrEmpty(chofer.nombre) ? "1=1" : ("nombre ='" + chofer.nombre) + "'") + (chofer.dni == 0 ? " And 1=1" : (" And usuario_dni =" + chofer.dni.ToString())) + (String.IsNullOrEmpty(chofer.apellido) ? " And 1=1" : (" And apellido ='" + chofer.apellido.ToString() + "'"));
                sqlCommand.CommandType = CommandType.Text; //Esto es opcional porque de base es un texto
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableChoferes = new DataTable();
                dataTableChoferes.Load(sqlReader);
                return dataTableChoferes;

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

        public static DataTable obtenerTodosLosChoferes()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, fecha_nacimiento FROM NONAME.Usuario join NONAME.Chofer on id_usuario = id_Chofer";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableChoferes = new DataTable();
                dataTableChoferes.Load(sqlReader);
                return dataTableChoferes;
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

        public static string modificarChofer(Chofer chofer)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_chofer_modificacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;
                sqlCommand.Parameters.AddWithValue("@id_usuario", chofer.id_Chofer);
                sqlCommand.Parameters.AddWithValue("@nombre", chofer.nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", chofer.apellido);
                sqlCommand.Parameters.AddWithValue("@usuario_dni", chofer.dni);
                sqlCommand.Parameters.AddWithValue("@mail", chofer.mail);
                sqlCommand.Parameters.AddWithValue("@telefono", chofer.telefono);
                sqlCommand.Parameters.AddWithValue("@direccion", chofer.direccion);
                sqlCommand.Parameters.AddWithValue("@fecha_nacimiento", chofer.fechaNacimiento);

                int response = sqlCommand.ExecuteNonQuery();

                if (response > 0)
                {
                    return "Chofer modificado correctamente";
                }
                else
                {
                    return "Fallo al modificar el chofer: " + chofer.nombre + " " + chofer.apellido;
                }
            }
            catch (Exception ex)
            {
                return "Fallo al modificar el chofer: "+chofer.nombre+" "+chofer.apellido;
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public int obtainIdChofer(string chofer)
        {
            chofer = chofer.Replace(' ', '_');
            int indexof_whitspace = chofer.IndexOf("_");
            string nombre = chofer.Substring(0, indexof_whitspace);
            string apellido = chofer.Substring(indexof_whitspace + 1);

            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Select id_usuario from NONAME.Usuario inner join NONAME.Chofer on id_usuario=id_chofer where nombre='" + nombre + "' and apellido='" + apellido + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;

            miConexion.Open();

            reader = cmd.ExecuteReader();

            // miConexion.Close();

            while (reader.Read())
            {
                return Convert.ToInt32(reader["id_usuario"]);
            }
            return 0;
        }

        public static string eliminarChofer(Chofer chofer)
        {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_chofer_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario", chofer.id_Chofer);

                int response=sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Chofer eliminado correctamente";
                }
                else
                {
                    return "Fallo al eliminar el chofer: " + chofer.nombre + " " + chofer.apellido;
                }
        }
    }
}


