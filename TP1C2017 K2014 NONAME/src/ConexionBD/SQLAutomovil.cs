using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using UberFrba.Objetos;
using System.Diagnostics;

namespace UberFrba.ConexionBD
{
    public class SQLAutomovil:ConexionSQL
    {
        static SqlCommand sqlCommand = new SqlCommand();
        

        public static void insertarAutomovil(Automovil auto) {
            try
            {
                conectar();

                sqlCommand = new SqlCommand("NONAME.sproc_automovil_alta");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@patente_auto", auto.patente);
                sqlCommand.Parameters.AddWithValue("@modelo", auto.modelo);
                DataTable columna = auto.idturno.DefaultView.ToTable(false, auto.idturno.Columns[0].ColumnName);
                sqlCommand.Parameters.AddWithValue("ids_turnos", columna);
                sqlCommand.Parameters.AddWithValue("@id_marca", auto.idmarca);
                sqlCommand.Parameters.AddWithValue("@rodado", auto.rodado);
                sqlCommand.Parameters.AddWithValue("@habilitado", auto.habilitado);
                sqlCommand.Parameters.AddWithValue("@licencia", auto.licencia);
                sqlCommand.Parameters.AddWithValue("@id_chofer", auto.idchofer);
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

        public static DataTable filtrarAutomoviles(Automovil auto) {
            try
            {
                conectar();

                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT AC.id_auto, A.patente_auto, A.modelo, A.id_marca, M.nombre, A.rodado, A.licencia, U.nombre, U.apellido, AC.id_turno, AC.id_chofer, A.habilitado FROM NONAME.Auto A join NONAME.Auto_Chofer AC on A.id_auto = AC.id_auto, NONAME.Usuario U, NONAME.Marca M WHERE U.id_usuario = AC.id_chofer And M.id_marca = A.id_marca And " + ((auto.idmarca == 0) ? "1=1" : ("A.id_marca ='" + auto.idmarca) + "'") + (String.IsNullOrEmpty(auto.modelo) ? " And 1=1" : (" And A.modelo ='" + auto.modelo + "'")) + (String.IsNullOrEmpty(auto.patente) ? " And 1=1" : (" And A.patente_auto ='" + auto.patente + "'")) + (String.IsNullOrEmpty(auto.nombreChofer) ? " And 1=1" : (" And U.nombre ='" + auto.nombreChofer + "' ")) + (String.IsNullOrEmpty(auto.apellidoChofer) ? " And 1=1" : (" And U.apellido ='" + auto.apellidoChofer + "'"));
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableAutos = new DataTable();
                dataTableAutos.Load(sqlReader);
                return dataTableAutos;
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

        public static DataTable filtrarAutomovilesHabilitados(Automovil auto)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT AC.id_auto, A.patente_auto, A.modelo, A.id_marca, M.nombre, A.rodado, A.licencia, U.nombre, U.apellido, AC.id_turno, AC.id_chofer, A.habilitado FROM NONAME.Auto A join NONAME.Auto_Chofer AC on A.id_auto = AC.id_auto, NONAME.Usuario U, NONAME.Marca M WHERE U.id_usuario = AC.id_chofer And M.id_marca = A.id_marca And A.habilitado = 1 And " + ((auto.idmarca == 0) ? "1=1" : ("A.id_marca ='" + auto.idmarca) + "'") + (String.IsNullOrEmpty(auto.modelo) ? " And 1=1" : (" And A.modelo ='" + auto.modelo + "'")) + (String.IsNullOrEmpty(auto.patente) ? " And 1=1" : (" And A.patente_auto ='" + auto.patente + "'")) + (String.IsNullOrEmpty(auto.nombreChofer) ? " And 1=1" : (" And U.nombre ='" + auto.nombreChofer + "' ")) + (String.IsNullOrEmpty(auto.apellidoChofer) ? " And 1=1" : (" And U.apellido ='" + auto.apellidoChofer + "' "));
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableAutos = new DataTable();
                dataTableAutos.Load(sqlReader);
                return dataTableAutos;
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
        public static DataTable obtenerTurnosDefinidosAuto(int id_auto){
            try
            {
                conectar();

                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT Turno.id_turno, Turno.descripcion FROM NONAME.Auto_Chofer inner join NONAME.Turno on Turno.id_turno=Auto_Chofer.id_turno WHERE id_auto= '" + id_auto + "'"; 
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableAutos = new DataTable();
                dataTableAutos.Load(sqlReader);
                return dataTableAutos;
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
        public static DataTable obtenerTodosLosAutomoviles()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT AC.id_auto, A.patente_auto, A.modelo, A.id_marca, M.nombre, A.rodado, A.licencia, U.nombre, U.apellido, AC.id_turno, AC.id_chofer, A.habilitado FROM NONAME.Auto A join NONAME.Auto_Chofer AC on A.id_auto = AC.id_auto, NONAME.Usuario U, NONAME.Marca M WHERE U.id_usuario = AC.id_chofer And M.id_marca = A.id_marca";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableAutos = new DataTable();
                dataTableAutos.Load(sqlReader);
                return dataTableAutos;
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

        public static DataTable obtenerTodosLosAutomovilesHabilitados()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT AC.id_auto, A.patente_auto, A.modelo, A.id_marca, M.nombre, A.rodado, A.licencia, U.nombre, U.apellido, AC.id_turno, AC.id_chofer, A.habilitado FROM NONAME.Auto A join NONAME.Auto_Chofer AC on A.id_auto = AC.id_auto, NONAME.Usuario U, NONAME.Marca M WHERE A.habilitado = 1 And U.id_usuario = AC.id_chofer And M.id_marca = A.id_marca";
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableAutos = new DataTable();
                dataTableAutos.Load(sqlReader);
                return dataTableAutos;
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


        public static void modificarAutomovil(Automovil auto)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_automovil_modificacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@patente_auto", auto.patente);
                sqlCommand.Parameters.AddWithValue("@modelo", auto.modelo);
                sqlCommand.Parameters.AddWithValue("@ids_turnos", auto.idturno);
                sqlCommand.Parameters.AddWithValue("@id_marca", auto.idmarca);
                sqlCommand.Parameters.AddWithValue("@rodado", auto.rodado);
                sqlCommand.Parameters.AddWithValue("@habilitado", auto.habilitado);
                sqlCommand.Parameters.AddWithValue("@licencia", auto.licencia);
                sqlCommand.Parameters.AddWithValue("@id_chofer", auto.idchofer);
                sqlCommand.Parameters.AddWithValue("@id_auto", auto.idautomovil);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static int eliminarAutomovil(Automovil auto)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_automovil_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_auto", auto.idautomovil);

                int response = sqlCommand.ExecuteNonQuery();

                return response;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally
            {
                desconectar();
            }
        }

        public static DataTable obtenerAutomovilDelChofer(int id_chofer, int id_turno)
        {
            try
            {
                conectar();

                sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "SELECT a.id_auto, a.patente_auto FROM NONAME.Auto a join NONAME.Auto_chofer c on c.id_auto = a.id_auto WHERE " + "c.id_chofer ='" + id_chofer + "'" + "And c.id_turno = '" + id_turno+"'";
                sqlCommand.CommandType = CommandType.Text; //Esto es opcional porque de base es un texto
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
                return dataTableClientes;

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

        public static DataTable obtenerTodasLasMarcas()
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_marca, nombre FROM NONAME.Marca";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableMarcas = new DataTable();
                dataTableMarcas.Load(sqlReader);
                return dataTableMarcas;
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

        public static bool verificarPatente(string patente, int idAuto)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT id_auto FROM NONAME.Auto Where patente_auto = '" + patente + "' And id_auto <> '" + idAuto + "'";
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

        public static bool verificarChofer(int idChofer, int idAuto)
        {
            try
            {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT A.id_auto FROM NONAME.Auto A join NONAME.Auto_Chofer AC on AC.id_auto = A.id_auto WHERE AC.id_chofer = '" + idChofer + "' And AC.id_auto <> '" + idAuto + "'";
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


