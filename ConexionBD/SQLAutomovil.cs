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
        

        public static string insertarAutomovil(Automovil auto) {
            conectar();

            sqlCommand = new SqlCommand("NONAME.sproc_automovil_alta");
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Connection = miConexion;
           
            sqlCommand.Parameters.AddWithValue("@patente_auto", auto.patente);
            sqlCommand.Parameters.AddWithValue("@modelo", auto.modelo);
            sqlCommand.Parameters.AddWithValue("@id_turno", auto.idturno);
            sqlCommand.Parameters.AddWithValue("@id_marca", auto.idmarca);
            sqlCommand.Parameters.AddWithValue("@rodado", auto.rodado);
            sqlCommand.Parameters.AddWithValue("@habilitado", auto.habilitado);
            sqlCommand.Parameters.AddWithValue("@licencia", auto.licencia);
            sqlCommand.Parameters.AddWithValue("@id_chofer", auto.idchofer);
            int response=sqlCommand.ExecuteNonQuery();
            if (response == 0)
            {
                return "No pudo realizarse la alta";
            }
            else{
                return "Alta realizada";
            }
    }
        public static List<String> obtain_marcas() {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT id_marca,nombre FROM Noname.Marca";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;


            System.Console.Write(cmd.CommandText);

            miConexion.Open();

            reader = cmd.ExecuteReader();
            List<String> marcas=new List<string>();
            while (reader.Read())
            {
                marcas.Add("["+reader["id_marca"].ToString()+"] "+reader["nombre"].ToString());
            }
            return  marcas;  
        }
        public static string obtainTurno(int idturno)
        {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT descripcion FROM Noname.Turno where id_turno="+idturno;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;


            System.Console.Write(cmd.CommandText);

            miConexion.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return reader["descripcion"].ToString();
            }
            return "";
        }
        public static string obtainMarca(int idmarca)
        {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT nombre FROM Noname.Marca where id_marca=" + idmarca;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;


            System.Console.Write(cmd.CommandText);

            miConexion.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return reader["nombre"].ToString();
            }
            return "";
        }
        public static string obtainChofer(int idchofer)
        {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "Select concat(nombre,' ', apellido) as chofer from NONAME.Usuario where id_usuario=" + idchofer ;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;


            System.Console.Write(cmd.CommandText);

            miConexion.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return reader["chofer"].ToString();
            }
            return "";
        }

        public static string obtainHabilitado(int idautomovil)
        {
            SqlConnection miConexion = new SqlConnection(ConexionSQL.cadenaConexion());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "select habilitado from NONAME.Auto where id_auto=" + idautomovil;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = miConexion;


            System.Console.Write(cmd.CommandText);

            miConexion.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return reader["habilitado"].ToString();
            }
            return "";
        }

        public static DataTable filtrarAutomoviles(Automovil auto) {
                conectar();

                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "Select Marca.nombre as marca, modelo, patente_auto, concat(Usuario.nombre, ' ', Usuario.apellido) as chofer, id_chofer from NONAME.Auto inner join NONAME.Marca on Auto.id_marca=marca.id_marca inner join NONAME.Auto_Chofer on Auto.id_auto=Auto_Chofer.id_auto inner join NONAME.Usuario on Auto_Chofer.id_chofer=Usuario.id_usuario WHERE " + ((auto.idmarca == 0) ? "1=1" : ("Marca.id_marca ='" + auto.idmarca) + "'") + (String.IsNullOrEmpty(auto.modelo) ? " And 1=1" : (" And modelo ='" + auto.modelo + "'")) + (String.IsNullOrEmpty(auto.patente) ? " And 1=1" : (" And patente_auto ='" + auto.patente + "'")) + (auto.idchofer == 0 ? " And 1=1" : (" And id_chofer ='" + auto.idchofer + "' group by patente_auto, Marca.nombre,Auto.modelo, Usuario.nombre, Usuario.apellido, Auto_Chofer.id_chofer"));
                sqlCommand.CommandType = CommandType.Text; //Esto es opcional porque de base es un texto
                sqlCommand.Connection = miConexion;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableAutos = new DataTable();
                dataTableAutos.Load(sqlReader);
                return dataTableAutos;     
        }

        public static DataTable obtenerTodosLosAutomoviles()
        {
                conectar();
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "SELECT Auto_Chofer.id_auto,Marca.nombre as marca, modelo, patente_auto, CONCAT(Usuario.nombre,' ',Usuario.apellido) as chofer FROM NONAME.Auto join NONAME.Marca on Auto.id_marca= Marca.id_marca join NONAME.Auto_Chofer on Auto_Chofer.id_auto=Auto.id_auto join NONAME.Usuario on Auto_Chofer.id_chofer=id_usuario";
                sqlCommand.CommandType = CommandType.Text; //opcional
                sqlCommand.Connection = miConexion;
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dataTableClientes = new DataTable();
                dataTableClientes.Load(sqlReader);
                return dataTableClientes;
          
        }

        public static string modificarAutomovil(Automovil auto)
        {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_automovil_modificacion");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@patente_auto", auto.patente);
                sqlCommand.Parameters.AddWithValue("@modelo", auto.modelo);
                sqlCommand.Parameters.AddWithValue("@id_turno", auto.idturno);
                sqlCommand.Parameters.AddWithValue("@id_marca", auto.idmarca);
                sqlCommand.Parameters.AddWithValue("@rodado", auto.rodado);
                sqlCommand.Parameters.AddWithValue("@habilitado", auto.habilitado);
                sqlCommand.Parameters.AddWithValue("@licencia", auto.licencia);
                sqlCommand.Parameters.AddWithValue("@id_chofer", auto.idchofer);
                sqlCommand.Parameters.AddWithValue("@id_auto", auto.idautomovil);

                int response=sqlCommand.ExecuteNonQuery();
                if (response > 0)
                {
                    return "Se modifico correctamente el automovil: " + auto.idautomovil;
                }
                else
                {
                    return "No se pudo realizar la modificacion";
                }
           
        }

        public static int eliminarAutomovil(Automovil auto)
        {
                conectar();
                sqlCommand = new SqlCommand("NONAME.sproc_automovil_baja");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Connection = miConexion;

                sqlCommand.Parameters.AddWithValue("@id_auto", auto.idautomovil);

                int response=sqlCommand.ExecuteNonQuery();

                return response;
                
        }
    }
}


