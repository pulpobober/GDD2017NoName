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


        public static void insertarChofer(Chofer chofer)
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

                sqlCommand.ExecuteNonQuery();

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

        public static DataTable filtrarChoferes(Chofer chofer)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, fecha_nacimiento, habilitado FROM NONAME.Chofer join NONAME.Usuario on id_Chofer = id_usuario WHERE " + (String.IsNullOrEmpty(chofer.nombre) ? "1=1" : ("nombre like '%" + chofer.nombre) + "%'") + (chofer.dni == 0 ? " And 1=1" : (" And usuario_dni = '" + chofer.dni.ToString() + "'")) + (String.IsNullOrEmpty(chofer.apellido) ? " And 1=1" : (" And apellido like '%" + chofer.apellido.ToString() + "%'"));
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableChoferes = new DataTable();
                dataTableChoferes.Load(sqlReader);
                return dataTableChoferes;

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

        public static DataTable filtrarChoferesHabilitados(Chofer chofer)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, fecha_nacimiento, habilitado FROM NONAME.Chofer join NONAME.Usuario on id_Chofer = id_usuario WHERE habilitado = 1 And " + (String.IsNullOrEmpty(chofer.nombre) ? "1=1" : ("nombre like '%" + chofer.nombre) + "%'") + (chofer.dni == 0 ? " And 1=1" : (" And usuario_dni = '" + chofer.dni.ToString() + "'")) + (String.IsNullOrEmpty(chofer.apellido) ? " And 1=1" : (" And apellido like '%" + chofer.apellido.ToString() + "%'"));
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableChoferes = new DataTable();
                dataTableChoferes.Load(sqlReader);
                return dataTableChoferes;

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

        public static DataTable obtenerTodosLosChoferes()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, fecha_nacimiento, habilitado FROM NONAME.Usuario join NONAME.Chofer on id_usuario = id_Chofer";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableChoferes = new DataTable();
                dataTableChoferes.Load(sqlReader);
                return dataTableChoferes;
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

        public static DataTable obtenerTodosLosChoferesHabilitados()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_usuario, nombre, apellido, usuario_dni, mail, telefono, direccion, fecha_nacimiento, habilitado FROM NONAME.Usuario join NONAME.Chofer on id_usuario = id_Chofer WHERE habilitado = 1";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableChoferes = new DataTable();
                dataTableChoferes.Load(sqlReader);
                return dataTableChoferes;
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

        public static void modificarChofer(Chofer chofer)
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
                sqlCommand.Parameters.AddWithValue("@habilitado", chofer.habilitado);
                
                sqlCommand.ExecuteNonQuery();
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

        public static string eliminarChofer(Chofer chofer)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_chofer_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_usuario", chofer.id_Chofer);

                int response = sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Chofer eliminado correctamente";
                }
                else
                {
                    return "Fallo al eliminar el chofer: " + chofer.nombre + " " + chofer.apellido;
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

        public static bool verificarTelefono(int telefono, int idChofer)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_usuario FROM NONAME.Usuario join NONAME.Chofer on id_usuario = id_chofer Where telefono = '" + telefono + "' And id_usuario <> '" + idChofer + "'";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);

                if (dataTableClientes.Rows.Count > 0)
                {
                    return false;
                }
                return true;
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

        public static bool verificarDNI(int dni, int idChofer)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_usuario FROM NONAME.Usuario join NONAME.Chofer on id_usuario = id_chofer Where usuario_dni = '" + dni + "' And id_usuario <> '" + idChofer + "'";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);

                if (dataTableClientes.Rows.Count > 0)
                {
                    return false;
                }
                return true;
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


